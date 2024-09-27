using Domain.Common.Models;

namespace Domain.Vocabulary.LetterNumbers.ValueObjects;

public sealed class LetterNumberId : ValueObject
{
    public Guid Value { get; }

    private LetterNumberId(Guid value)
    {
        Value = value;
    }

    public static LetterNumberId Create(Guid value)
    {
        return new LetterNumberId(value);
    }

    public static LetterNumberId CreateUnique()
    {
        return new LetterNumberId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}