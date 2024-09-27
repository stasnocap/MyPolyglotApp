using Domain.Common.Models;

namespace Domain.Vocabulary.LetterNumbers.ValueObjects;

public sealed class Number : ValueObject
{
    public int Value { get; }

    private Number(int value)
    {
        Value = value;
    }

    public static Number Create(int value)
    {
        return new Number(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}