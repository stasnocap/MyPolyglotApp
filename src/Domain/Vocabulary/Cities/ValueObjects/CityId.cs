using Domain.Common.Models;

namespace Domain.Vocabulary.Cities.ValueObjects;

public sealed class CityId : ValueObject
{
    public Guid Value { get; }

    private CityId(Guid value)
    {
        Value = value;
    }

    public static CityId Create(Guid value)
    {
        return new CityId(value);
    }
    
    public static CityId CreateUnique()
    {
        return new CityId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}