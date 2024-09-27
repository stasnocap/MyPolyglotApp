using Domain.Common.Models;

namespace Domain.Vocabulary.Nouns.ValueObjects;

public sealed class NounId : ValueObject
{
    public Guid Value { get; }

    private NounId(Guid value)
    {
        Value = value;
    }

    public static NounId Create(Guid value)
    {
        return new NounId(value);
    }
    
    public static NounId CreateUnique()
    {
        return new NounId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}