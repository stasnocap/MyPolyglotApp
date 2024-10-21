using Domain.Common.Models;

namespace Domain.Practice.Scores.ValueObjects;

public sealed class ScoreValue : ValueObject
{
    public int Value { get; private set; }

    private ScoreValue(int value)
    {
        Value = value;
    }

    public static ScoreValue Create(int value = 0)
    {
        return new ScoreValue(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}