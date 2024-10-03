using Domain.Practice.Exercises.Errors;
using Domain.Practice.Exercises.ValueObjects;
using FluentAssertions;

namespace Domain.UnitTests.Exercises.ValueObjects;

public class EngPhraseTests
{
    [Fact]
    public void ShouldReturnError_WhenValueIsNull()
    {
        var errorOrEngPhrase = EngPhrase.Create(null!);

        errorOrEngPhrase.IsError.Should().BeTrue();
        errorOrEngPhrase.Errors.Count.Should().Be(1);
        errorOrEngPhrase.Errors[0].Should().Be(ExerciseErrors.EmptyEngPhrase);
    }
    
    [Fact]
    public void ShouldReturnError_WhenValueIsEmpty()
    {
        var errorOrEngPhrase = EngPhrase.Create("");

        errorOrEngPhrase.IsError.Should().BeTrue();
        errorOrEngPhrase.Errors.Count.Should().Be(1);
        errorOrEngPhrase.Errors[0].Should().Be(ExerciseErrors.EmptyEngPhrase);
    }
    
    [Fact]
    public void ShouldReturnNewPhrase_WhenValueIsNotEmpty()
    {
        var errorOrEngPhrase = EngPhrase.Create("Моя фраза.");

        errorOrEngPhrase.IsError.Should().BeFalse();
        var engPhrase = errorOrEngPhrase.Value;
        engPhrase.Value.Should().Be("Моя фраза.");
    }
}