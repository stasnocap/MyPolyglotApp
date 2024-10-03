using Domain.Common.Models;
using Domain.Practice.Exercises.Errors;
using ErrorOr;

namespace Domain.Practice.Exercises.ValueObjects;

public sealed class WordNumber : ValueObject
{
    public int Value { get; }

    private WordNumber(int value)
    {
        Value = value;
    }

    public static ErrorOr<WordNumber> Create(int value)
    {
        if (value < 1)
        {
            return WordErrors.NegativeNumber;
        }

        return new WordNumber(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}