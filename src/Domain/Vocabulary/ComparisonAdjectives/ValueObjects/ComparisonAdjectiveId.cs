using Domain.Common.Models;

namespace Domain.Vocabulary.ComparisonAdjectives.ValueObjects;

public sealed class ComparisonAdjectiveId : ValueObject
{
    public Guid Value { get; }

    private ComparisonAdjectiveId(Guid value)
    {
        Value = value;
    }

    public static ComparisonAdjectiveId Create(Guid value)
    {
        return new ComparisonAdjectiveId(value);
    }
    
    public static ComparisonAdjectiveId CreateUnique()
    {
        return new ComparisonAdjectiveId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}