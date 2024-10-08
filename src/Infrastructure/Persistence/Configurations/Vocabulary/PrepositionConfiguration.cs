using Domain.Common.ValueObjects;
using Domain.Vocabulary.Prepositions;
using Domain.Vocabulary.Prepositions.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class PrepositionConfiguration : IEntityTypeConfiguration<Preposition>
{
    public void Configure(EntityTypeBuilder<Preposition> builder)
    {
        builder.ToTable("Prepositions", schema: Schemas.Vocabulary);

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => PrepositionId.Create(value));

        builder.Property(c => c.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.HasData(PrepositionSeed.GetPrepositions());
    }
}