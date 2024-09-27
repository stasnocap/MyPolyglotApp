using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Compounds.ValueObjects;

namespace Domain.Vocabulary.Compounds;

public sealed class Compound : BaseWord<CompoundId>
{
    private Compound(CompoundId id, Text text) : base(id, text)
    {
    }

    public static Compound Create(Text text)
    {
        return new Compound(CompoundId.CreateUnique(), text);
    }
}