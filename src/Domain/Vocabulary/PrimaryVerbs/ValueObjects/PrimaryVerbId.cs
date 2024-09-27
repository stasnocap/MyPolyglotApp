using Domain.Common.Models;

namespace Domain.Vocabulary.PrimaryVerbs.ValueObjects;

public class PrimaryVerbId : ValueObject
{
    public Guid Value { get; }

    private PrimaryVerbId(Guid value)
    {
        Value = value;
    }

    public static PrimaryVerbId Create(Guid value)
    {
        return new PrimaryVerbId(value);
    }

    public static PrimaryVerbId CreateUnique()
    {
        return new PrimaryVerbId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}