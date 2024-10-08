using Domain.Common.ValueObjects;
using Domain.Vocabulary.LetterNumbers;
using Domain.Vocabulary.LetterNumbers.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class LetterNumberConfiguration : IEntityTypeConfiguration<LetterNumber>
{
    public void Configure(EntityTypeBuilder<LetterNumber> builder)
    {
        builder.ToTable("LetterNumbers", schema: Schemas.Vocabulary);

        builder.HasKey(ln => ln.Id);

        builder.Property(ln => ln.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => LetterNumberId.Create(value));

        builder.Property(ln => ln.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.Property(ln => ln.Number)
            .HasConversion(number => number.Value, value => Number.Create(value));

        builder.HasData(LetterNumberSeed.GetLetterNumbers());
    }
}