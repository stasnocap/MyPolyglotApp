using Domain.Common.Models;

namespace Domain.Vocabulary.Verbs.ValueObjects;

public sealed class VerbId : ValueObject
{
    public Guid Value { get; }

    private VerbId(Guid value)
    {
        Value = value;
    }

    public static VerbId Create(Guid value)
    {
        return new VerbId(value);
    }

    public static VerbId CreateUnique()
    {
        return new VerbId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}