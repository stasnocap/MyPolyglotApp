using Domain.Common.Models;

namespace Domain.Vocabulary.Prepositions.ValueObjects;

public sealed class PrepositionId : ValueObject
{
    public Guid Value { get; }

    private PrepositionId(Guid value)
    {
        Value = value;
    }

    public static PrepositionId Create(Guid value)
    {
        return new PrepositionId(value);
    }
    
    public static PrepositionId CreateUnique()
    {
        return new PrepositionId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}