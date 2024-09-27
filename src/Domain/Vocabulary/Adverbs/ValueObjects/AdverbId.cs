using Domain.Common.Models;

namespace Domain.Vocabulary.Adverbs.ValueObjects;

public sealed class AdverbId : ValueObject
{
    public Guid Value { get; }

    private AdverbId(Guid value)
    {
        Value = value;
    }

    public static AdverbId Create(Guid value)
    {
        return new AdverbId(value);
    }
    
    public static AdverbId CreateUnique()
    {
        return new AdverbId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}