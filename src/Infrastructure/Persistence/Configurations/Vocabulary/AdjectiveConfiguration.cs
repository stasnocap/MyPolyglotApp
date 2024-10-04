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
        builder.ToTable("Adjectives", schema: Schemas.Practice);

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => AdjectiveId.Create(value));

        builder.Property(e => e.Text)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.HasData(AdjectiveSeed.GetAdjectives());
    }
}