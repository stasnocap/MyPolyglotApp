using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Compounds.ValueObjects;

namespace Domain.Vocabulary.Compounds;

public sealed class Compound : BaseWord<CompoundId>
{
    public CompoundType Type { get; }

    private Compound(CompoundId id, Text text, CompoundType type) : base(id, text)
    {
        Type = type;
    }

    public static Compound Create(Text text, CompoundType type)
    {
        return new Compound(CompoundId.CreateUnique(), text, type);
    }

    public static Compound Create(CompoundId compoundId, Text text, CompoundType type)
    {
        return new Compound(compoundId, text, type);
    }
}