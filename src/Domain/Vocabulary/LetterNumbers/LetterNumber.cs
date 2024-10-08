using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.LetterNumbers.ValueObjects;

namespace Domain.Vocabulary.LetterNumbers;

public sealed class LetterNumber : BaseWord<LetterNumberId>
{
    public Number Number { get; }

    private LetterNumber(LetterNumberId id, Text text, Number number) : base(id, text)
    {
        Number = number;
    }

    public static LetterNumber Create(Text text, Number number)
    {
        return new LetterNumber(LetterNumberId.CreateUnique(), text, number);
    }

    public static LetterNumber Create(LetterNumberId letterNumberId, Text text, Number number)
    {
        return new LetterNumber(letterNumberId, text, number);
    }
}