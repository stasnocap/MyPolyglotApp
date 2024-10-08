using Domain.Common.ValueObjects;
using Domain.Vocabulary.Verbs;
using Domain.Vocabulary.Verbs.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class VerbConfiguration : IEntityTypeConfiguration<Verb>
{
    public void Configure(EntityTypeBuilder<Verb> builder)
    {
        builder.ToTable("Verbs", schema: Schemas.Vocabulary);

        builder.HasKey(pv => pv.Id);

        builder.Property(pv => pv.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => VerbId.Create(value));

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

        builder.Property(pv => pv.IsIrregularVerb)
            .HasConversion(isIrregularVerb => isIrregularVerb.Value, value => IsIrregularVerb.Create(value));

        builder.HasData(VerbSeed.GetVerbs());
    }
}