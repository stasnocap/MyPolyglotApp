using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Prepositions.ValueObjects;

namespace Domain.Vocabulary.Prepositions;

public sealed class Preposition : BaseWord<PrepositionId>
{
    private Preposition(PrepositionId id, Text text) : base(id, text)
    {
    }

    public static Preposition Create(Text text)
    {
        return new Preposition(PrepositionId.CreateUnique(), text);
    }

    public static Preposition Create(PrepositionId prepositionId, Text text)
    {
        return new Preposition(prepositionId, text);
    }
}