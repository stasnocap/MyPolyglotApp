using Domain.Common.ValueObjects;
using Domain.Vocabulary.QuestionWords;
using Domain.Vocabulary.QuestionWords.ValueObjects;
using Infrastructure.Persistence.Seed.Practice;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class QuestionWordConfiguration : IEntityTypeConfiguration<QuestionWord>
{
    public void Configure(EntityTypeBuilder<QuestionWord> builder)
    {
        builder.ToTable("QuestionWords", schema: Schemas.Vocabulary);

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => QuestionWordId.Create(value));

        builder.Property(c => c.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.HasData(QuestionWordSeed.GetQuestionWords());
    }
}