using Domain.Common.ValueObjects;
using Domain.Vocabulary.Pronouns;
using Domain.Vocabulary.Pronouns.ValueObjects;
using Infrastructure.Persistence.Seed.Vocabulary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.Vocabulary;

public class PronounConfiguration : IEntityTypeConfiguration<Pronoun>
{
    public void Configure(EntityTypeBuilder<Pronoun> builder)
    {
        builder.ToTable("Pronouns", schema: Schemas.Vocabulary);

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .ValueGeneratedNever()
            .HasConversion(id => id.Value, value => PronounId.Create(value));

        builder.Property(p => p.Text)
            .HasConversion(text => text.Value, value => Text.Create(value).Value);

        builder.Property(p => p.Type);

        builder.HasData(PronounSeed.GetPronouns());
    }
}