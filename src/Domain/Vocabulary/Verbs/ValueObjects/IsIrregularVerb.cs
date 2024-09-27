using Domain.Common.Models;

namespace Domain.Vocabulary.Verbs.ValueObjects;

public sealed class IsIrregularVerb : ValueObject
{
    public bool Value { get; }

    private IsIrregularVerb(bool value)
    {
        Value = value;
    }

    public static IsIrregularVerb Create(bool value)
    {
        return new IsIrregularVerb(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}