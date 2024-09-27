using Domain.Common.Models;

namespace Domain.Scores.ValueObjects;

public sealed class ScoreId : ValueObject
{
    public Guid Value { get; }

    private ScoreId(Guid value)
    {
        Value = value;
    }
    
    public static ScoreId Create(Guid id)
    {
        return new(id);
    }

    public static ScoreId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}