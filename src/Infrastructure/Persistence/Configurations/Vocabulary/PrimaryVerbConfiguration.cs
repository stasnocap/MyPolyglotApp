using Domain.Common.ValueObjects;
using Domain.Vocabulary.PrimaryVerbs;
using Domain.Vocabulary.PrimaryVerbs.ValueObjects;
using Domain.Vocabulary.Verbs.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class PrimaryVerbConfiguration : IEntityTypeConfiguration<PrimaryVerb>
{
    public void Configure(EntityTypeBuilder<PrimaryVerb> builder)
    {
        ConfigurePrimaryVerbs(builder);
        ConfigureFullNegativeForms(builder);
        ConfigureShortNegativeForms(builder);
        ConfigureAdditionalForms(builder);
    }

    private void ConfigureAdditionalForms(EntityTypeBuilder<PrimaryVerb> builder)
    {
        builder.OwnsMany(pv => pv.AdditionalForms, additionalForms =>
        {
            additionalForms.ToTable("AdditionalForms");

            additionalForms.WithOwner().HasForeignKey("PrimaryVerbId");

            additionalForms.HasKey("Id");

            additionalForms.Property(fnf => fnf.Value)
                .HasColumnName("Text");

            additionalForms.HasData(PrimaryVerbSeed.GetAdditionalForms());
        });

        builder.Metadata.FindNavigation(nameof(PrimaryVerb.AdditionalForms))!.SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureShortNegativeForms(EntityTypeBuilder<PrimaryVerb> builder)
    {
        builder.OwnsMany(pv => pv.ShortNegativeForms, shortNegativeForms =>
        {
            shortNegativeForms.ToTable("ShortNegativeForms");

            shortNegativeForms.WithOwner().HasForeignKey("PrimaryVerbId");

            shortNegativeForms.HasKey("Id");

            shortNegativeForms.Property(fnf => fnf.Value)
                .HasColumnName("Text");

            shortNegativeForms.HasData(PrimaryVerbSeed.GetShortNegativeForms());
        });

        builder.Metadata.FindNavigation(nameof(PrimaryVerb.ShortNegativeForms))!.SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private void ConfigureFullNegativeForms(EntityTypeBuilder<PrimaryVerb> builder)
    {
        builder.OwnsMany(pv => pv.FullNegativeForms, fullNegativeForms =>
        {
            fullNegativeForms.ToTable("FullNegativeForms");

            fullNegativeForms.WithOwner().HasForeignKey("PrimaryVerbId");

            fullNegativeForms.HasKey("Id");

            fullNegativeForms.Property(fnf => fnf.Value)
                .HasColumnName("Text");

            fullNegativeForms.HasData(PrimaryVerbSeed.GetFullNegativeForms());
        });

        builder.Metadata.FindNavigation(nameof(PrimaryVerb.FullNegativeForms))!.SetPropertyAccessMode(PropertyAccessMode.Field);
    }

    private static void ConfigurePrimaryVerbs(EntityTypeBuilder<PrimaryVerb> builder)
    {
        builder.ToTable("PrimaryVerbs", schema: Schemas.Vocabulary);

        builder.HasKey(pv => pv.Id);

        builder.Property(pv => pv.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => PrimaryVerbId.Create(value));

        builder.Property(pv => pv.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.Property(pv => pv.PastForm)
            .HasMaxLength(100)
            .HasConversion(pastForm => pastForm.Value, value => PastForm.Create(value).Value);

        builder.Property(pv => pv.PastParticipleForm)
            .HasMaxLength(100)
            .HasConversion(pastParticipleForm => pastParticipleForm.Value, value => PastParticipleForm.Create(value).Value);

        builder.Property(pv => pv.PresentParticipleForm)
            .HasMaxLength(100)
            .HasConversion(presentParticipleForm => presentParticipleForm.Value, value => PresentParticipleForm.Create(value).Value);

        builder.Property(pv => pv.ThirdPersonForm)
            .HasMaxLength(100)
            .HasConversion(thirdPersonForm => thirdPersonForm.Value, value => ThirdPersonForm.Create(value).Value);

        builder.HasData(PrimaryVerbSeed.GetPrimaryVerbs());
    }
}