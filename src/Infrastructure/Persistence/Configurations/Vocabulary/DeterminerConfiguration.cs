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
        builder.ToTable("Determiners", schema: Schemas.Practice);

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => DeterminerId.Create(value));

        builder.Property(c => c.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.HasData(DeterminerSeed.GetDeterminers());
    }
}