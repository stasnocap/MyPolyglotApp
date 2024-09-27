using Domain.Common.Models;

namespace Domain.Vocabulary.Compounds.ValueObjects;

public sealed class CompoundId : ValueObject
{
    public Guid Value { get; }

    private CompoundId(Guid value)
    {
        Value = value;
    }

    public static CompoundId Create(Guid value)
    {
        return new CompoundId(value);
    }
    
    public static CompoundId CreateUnique()
    {
        return new CompoundId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}