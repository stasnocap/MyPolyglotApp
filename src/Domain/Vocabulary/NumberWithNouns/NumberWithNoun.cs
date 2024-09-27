using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.NumberWithNouns.ValueObjects;

namespace Domain.Vocabulary.NumberWithNouns;

public sealed class NumberWithNoun : BaseWord<NumberWithNounId>
{
    private NumberWithNoun(NumberWithNounId id, Text text) : base(id, text)
    {
    }

    public static NumberWithNoun Create(Text text)
    {
        return new NumberWithNoun(NumberWithNounId.CreateUnique(), text);
    }
}