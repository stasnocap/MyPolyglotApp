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

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => ComparisonAdjectiveId.Create(value));

        builder.Property(a => a.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.Property(a => a.ComparativeForm)
            .HasMaxLength(100)
            .HasConversion(comparativeForm => comparativeForm.Value, value => ComparativeForm.Create(value).Value);

        builder.Property(a => a.SuperlativeForm)
            .HasMaxLength(100)
            .HasConversion(superlativeForm => superlativeForm.Value, value => SuperlativeForm.Create(value).Value);

        builder.Property(a => a.SyllablesCount)
            .HasConversion(sylleblesCount => sylleblesCount.Value, value => SyllablesCount.Create(value).Value);

        builder.HasData(ComparisonAdjectiveSeed.GetComparisonAdjectives());
    }
}