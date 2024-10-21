using Domain.Common.Models;

namespace Domain.Practice.Scores.ValueObjects;

public class Rating : ValueObject
{
    private const float SuccessMultiplier = 0.1f;
    private const float WrongMultiplier = 0.15f;
    private const float MaxRate = 5f;
    private const float MinRate = 0;
    
    public int CorrectNumber { get; private set; }

    public int WrongNumber { get; private set; }

    public float Rate { get; private set; }

    private Rating(int correctNumber, int wrongNumber, float rate)
    {
        CorrectNumber = correctNumber;
        WrongNumber = wrongNumber;
        Rate = rate;
    }

    public static Rating Create()
    {
        return new Rating(0, 0, 0);
    }

    public static Rating Create(int correctNumber, int wrongNumber, float rate)
    {
        return new Rating(correctNumber, wrongNumber, rate);
    }

    public void Increase()
    {
        CorrectNumber++;
        CalculateRate();
    }

    public void Decrease()
    {
        WrongNumber++;
        CalculateRate();
    }

    private void CalculateRate()
    {
        var rate = CorrectNumber * SuccessMultiplier - WrongNumber * WrongMultiplier;

        Rate = rate switch
        {
            > MaxRate => MaxRate,
            < MinRate => MinRate,
            _ => rate
        };
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return CorrectNumber;
        yield return WrongNumber;
        yield return Rate;
    }
}