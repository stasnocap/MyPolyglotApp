using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Determiners.ValueObjects;

namespace Domain.Vocabulary.Determiners;

public sealed class Determiner : BaseWord<DeterminerId>
{
    private Determiner(DeterminerId id, Text text) : base(id, text)
    {
    }

    public static Determiner Create(Text text)
    {
        return new Determiner(DeterminerId.CreateUnique(), text);
    }

    public static Determiner Create(DeterminerId determinerId, Text text)
    {
        return new Determiner(determinerId, text);
    }
}