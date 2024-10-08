using Domain.Common.ValueObjects;
using Domain.Vocabulary.Determiners;
using Domain.Vocabulary.Determiners.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class DeterminerConfiguration : IEntityTypeConfiguration<Determiner>
{
    public void Configure(EntityTypeBuilder<Determiner> builder)
    {
        builder.ToTable("Determiners", schema: Schemas.Vocabulary);

        builder.HasKey(d => d.Id);

        builder.Property(d => d.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => DeterminerId.Create(value));

        builder.Property(d => d.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.HasData(DeterminerSeed.GetDeterminers());
    }
}