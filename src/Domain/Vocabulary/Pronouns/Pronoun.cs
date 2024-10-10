using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Pronouns.ValueObjects;

namespace Domain.Vocabulary.Pronouns;

public sealed class Pronoun : BaseWord<PronounId>
{
    public PronounType Type { get; }

    private Pronoun(PronounId id, Text text, PronounType type) : base(id, text)
    {
        Type = type;
    }

    public static Pronoun Create(Text text, PronounType type)
    {
        return new Pronoun(PronounId.CreateUnique(), text, type);
    }

    public static Pronoun Create(PronounId pronounId, Text text, PronounType type)
    {
        return new Pronoun(pronounId, text, type);
    }
}