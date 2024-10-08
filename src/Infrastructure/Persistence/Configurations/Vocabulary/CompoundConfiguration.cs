using Domain.Common.ValueObjects;
using Domain.Vocabulary.Compounds;
using Domain.Vocabulary.Compounds.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class CompoundConfiguration : IEntityTypeConfiguration<Compound>
{
    public void Configure(EntityTypeBuilder<Compound> builder)
    {
        builder.ToTable("Compounds", schema: Schemas.Vocabulary);

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => CompoundId.Create(value));

        builder.Property(c => c.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.Property(c => c.Type);

        builder.HasData(CompoundSeed.GetCompounds());
    }
}