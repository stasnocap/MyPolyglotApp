using Domain.Common.ValueObjects;
using Domain.Vocabulary.Pronouns;
using Domain.Vocabulary.Pronouns.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class PronounSeed
{
    public static IReadOnlyList<Pronoun> GetPronouns()
    {
        return
        [
            Pronoun.Create(PronounId.Create(Guid.Parse("c5e9499f-6682-4de2-bb4c-f6cf2c3e5e7f")), Text.Create("i").Value),
            Pronoun.Create(PronounId.Create(Guid.Parse("95280413-d92d-4907-827e-1bd3fadd5f20")), Text.Create("you").Value),
            Pronoun.Create(PronounId.Create(Guid.Parse("004a6a6b-bb91-4d03-bec1-ba2529fab0c0")), Text.Create("he").Value),
            Pronoun.Create(PronounId.Create(Guid.Parse("1a412290-7271-4385-8fc9-f08be3b0452c")), Text.Create("she").Value),
            Pronoun.Create(PronounId.Create(Guid.Parse("575963a0-80f7-4024-9c82-90e52aea846a")), Text.Create("it").Value),
            Pronoun.Create(PronounId.Create(Guid.Parse("60a86ad4-6d5f-4874-819a-61f9c200b7b1")), Text.Create("we").Value),
            Pronoun.Create(PronounId.Create(Guid.Parse("0bb651d1-cc92-41a5-9b24-2934db01ed07")), Text.Create("they").Value),
        ];
    }
}