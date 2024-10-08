using Domain.Common.ValueObjects;
using Domain.Vocabulary.ComparisonAdjectives;
using Domain.Vocabulary.ComparisonAdjectives.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class ComparisonAdjectiveConfiguration : IEntityTypeConfiguration<ComparisonAdjective>
{
    public void Configure(EntityTypeBuilder<ComparisonAdjective> builder)
    {
        builder.ToTable("ComparisonAdjectives", schema: Schemas.Practice);

        builder.HasKey(ca => ca.Id);

        builder.Property(ca => ca.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => ComparisonAdjectiveId.Create(value));

        builder.Property(ca => ca.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.Property(ca => ca.ComparativeForm)
            .HasMaxLength(100)
            .HasConversion(comparativeForm => comparativeForm.Value, value => ComparativeForm.Create(value).Value);

        builder.Property(ca => ca.SuperlativeForm)
            .HasMaxLength(100)
            .HasConversion(superlativeForm => superlativeForm.Value, value => SuperlativeForm.Create(value).Value);

        builder.Property(ca => ca.SyllablesCount)
            .HasConversion(sylleblesCount => sylleblesCount.Value, value => SyllablesCount.Create(value).Value);

        builder.HasData(ComparisonAdjectiveSeed.GetComparisonAdjectives());
    }
}