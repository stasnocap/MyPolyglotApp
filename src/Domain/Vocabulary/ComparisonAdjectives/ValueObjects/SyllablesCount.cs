using Domain.Common.Models;
using Domain.Vocabulary.ComparisonAdjectives.Errors;
using ErrorOr;

namespace Domain.Vocabulary.ComparisonAdjectives.ValueObjects;

public sealed class SyllablesCount : ValueObject
{
    public int Value { get; }

    private SyllablesCount(int value)
    {
        Value = value;
    }

    public static ErrorOr<SyllablesCount> Create(int value)
    {
        if (value < 1)
        {
            return ComparisonAdjectiveErrors.SyllablesCountNegative;
        }
        
        return new SyllablesCount(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}