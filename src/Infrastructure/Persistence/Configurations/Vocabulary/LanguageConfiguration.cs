using Domain.Common.ValueObjects;
using Domain.Vocabulary.Languages;
using Domain.Vocabulary.Languages.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.ToTable("Languages", schema: Schemas.Vocabulary);

        builder.HasKey(l => l.Id);

        builder.Property(l => l.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => LanguageId.Create(value));

        builder.Property(l => l.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.HasData(LanguageSeed.GetLanguages());
    }
}