using Domain.Common.ValueObjects;
using Domain.Vocabulary.Adverbs;
using Domain.Vocabulary.Adverbs.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class AdverbConfiguration : IEntityTypeConfiguration<Adverb>
{
    public void Configure(EntityTypeBuilder<Adverb> builder)
    {
        builder.ToTable("Adverbs", schema: Schemas.Vocabulary);

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => AdverbId.Create(value));

        builder.Property(a => a.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.Property(a => a.Type);

        builder.HasData(AdverbSeed.GetAdverbs());
    }
}