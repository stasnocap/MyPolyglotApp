using Domain.Common.Models;

namespace Domain.Exercises.ValueObjects;

public sealed class WordId : ValueObject
{
    public Guid Value { get; }

    private WordId(Guid value)
    {
        Value = value;
    }
    
    public static WordId Create(Guid id)
    {
        return new(id);
    }

    public static WordId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}