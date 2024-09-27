using Domain.Common.Models;

namespace Domain.Vocabulary.Verbs.ValueObjects;

public sealed class StressOnFinalSyllable : ValueObject
{
    public bool Value { get; }

    private StressOnFinalSyllable(bool value)
    {
        Value = value;
    }

    public static StressOnFinalSyllable Create(bool value)
    {
        return new StressOnFinalSyllable(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}