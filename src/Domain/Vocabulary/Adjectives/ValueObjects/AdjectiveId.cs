using Domain.Common.Models;

namespace Domain.Vocabulary.Adjectives.ValueObjects;

public sealed class AdjectiveId : ValueObject
{
    public Guid Value { get; }

    private AdjectiveId(Guid value)
    {
        Value = value;
    }

    public static AdjectiveId Create(Guid value)
    {
        return new AdjectiveId(value);
    }
    
    public static AdjectiveId CreateUnique()
    {
        return new AdjectiveId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}