using Domain.Common.ValueObjects;
using Domain.Vocabulary.ModalVerbs;
using Domain.Vocabulary.ModalVerbs.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class ModalVerbConfiguration : IEntityTypeConfiguration<ModalVerb>
{
    public void Configure(EntityTypeBuilder<ModalVerb> builder)
    {
        builder.ToTable("ModalVerbs", schema: Schemas.Vocabulary);

        builder.HasKey(mv => mv.Id);

        builder.Property(mv => mv.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => ModalVerbId.Create(value));

        builder.Property(mv => mv.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.Property(mv => mv.FullNegativeForm)
            .HasMaxLength(100)
            .HasConversion(fullNegativeForm => fullNegativeForm.Value, value => FullNegativeForm.Create(value).Value);

        builder.Property(mv => mv.ShortNegativeForm)
            .HasMaxLength(100)
            .HasConversion(shortNegativeForm => shortNegativeForm.Value, value => ShortNegativeForm.Create(value).Value);

        builder.HasData(ModalVerbSeed.GetModalVerbs());
    }
}