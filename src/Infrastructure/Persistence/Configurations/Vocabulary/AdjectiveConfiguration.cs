using Domain.Common.ValueObjects;
using Domain.Vocabulary.Adjectives;
using Domain.Vocabulary.Adjectives.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class AdjectiveConfiguration : IEntityTypeConfiguration<Adjective>
{
    public void Configure(EntityTypeBuilder<Adjective> builder)
    {
        builder.ToTable("Adjectives", schema: Schemas.Vocabulary);

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => AdjectiveId.Create(value));

        builder.Property(a => a.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.HasData(AdjectiveSeed.GetAdjectives());
    }
}