using Domain.Common.Models;

namespace Domain.Vocabulary.Determiners.ValueObjects;

public sealed class DeterminerId : ValueObject
{
    public Guid Value { get; }

    private DeterminerId(Guid value)
    {
        Value = value;
    }

    public static DeterminerId Create(Guid value)
    {
        return new DeterminerId(value);
    }
    
    public static DeterminerId CreateUnique()
    {
        return new DeterminerId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}