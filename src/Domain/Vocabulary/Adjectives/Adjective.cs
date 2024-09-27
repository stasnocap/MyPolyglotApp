using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Adjectives.ValueObjects;

namespace Domain.Vocabulary.Adjectives;

public sealed class Adjective : BaseWord<AdjectiveId>
{
    private Adjective(AdjectiveId id, Text text) : base(id, text)
    {
    }

    public static Adjective Create(Text text)
    {
        return new Adjective(AdjectiveId.CreateUnique(), text);
    }
}