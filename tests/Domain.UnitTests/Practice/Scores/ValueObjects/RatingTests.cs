using Domain.Practice.Scores.ValueObjects;
using FluentAssertions;

namespace Domain.UnitTests.Practice.Scores.ValueObjects;

public class RatingTests
{
    [Theory]
    [InlineData(50, 0, 5)]
    [InlineData(60, 0, 5)]
    [InlineData(60, 100, 0)]
    public void ShouldCalculateCorrectRate(int correctNumber, int wrongNumber, float rate)
    {
        var rating = Rating.Create(correctNumber - 1, wrongNumber, 0);
        
        rating.Increase();

        rating.Rate.Should().Be(rate);
    }
}