using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Pronouns.ValueObjects;

namespace Domain.Vocabulary.Pronouns;

public sealed class Pronoun : BaseWord<PronounId>
{
    private Pronoun(PronounId id, Text text) : base(id, text)
    {
    }

    public static Pronoun Create(Text text)
    {
        return new Pronoun(PronounId.CreateUnique(), text);
    }
}