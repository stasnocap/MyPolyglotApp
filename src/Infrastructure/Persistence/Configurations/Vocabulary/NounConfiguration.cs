using Domain.Common.ValueObjects;
using Domain.Vocabulary.Nouns;
using Domain.Vocabulary.Nouns.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class NounConfiguration : IEntityTypeConfiguration<Noun>
{
    public void Configure(EntityTypeBuilder<Noun> builder)
    {
        builder.ToTable("Nouns", schema: Schemas.Vocabulary);

        builder.HasKey(n => n.Id);

        builder.Property(n => n.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => NounId.Create(value));

        builder.Property(n => n.Text)
            .HasMaxLength(100)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.Property(n => n.PluralForm)
            .HasMaxLength(100)
            .HasConversion(pluralForm => pluralForm.Value, value => PluralForm.Create(value).Value);

        builder.Property(n => n.Type);

        builder.HasData(NounSeed.GetNouns());
    }
}