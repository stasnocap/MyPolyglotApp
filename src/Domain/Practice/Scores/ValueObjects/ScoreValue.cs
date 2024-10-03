using Domain.Common.Models;

namespace Domain.Practice.Scores.ValueObjects;

public sealed class ScoreValue : ValueObject
{
    public int Value { get; private set; }

    private ScoreValue(int value)
    {
        Value = value;
    }

    public static ScoreValue Create()
    {
        return new ScoreValue(0);
    }

    public void Increase()
    {
        Value++;
    }

    public void Decrease()
    {
        Value--;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}