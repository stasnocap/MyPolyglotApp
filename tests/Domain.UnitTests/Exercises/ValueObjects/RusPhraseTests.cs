using Domain.Exercises.Errors;
using Domain.Exercises.ValueObjects;
using FluentAssertions;

namespace Domain.UnitTests.Exercises.ValueObjects;

public class RusPhraseTests
{
    [Fact]
    public void ShouldReturnError_WhenValueIsNull()
    {
        var errorOrRusPhrase = RusPhrase.Create(null!);

        errorOrRusPhrase.IsError.Should().BeTrue();
        errorOrRusPhrase.Errors.Count.Should().Be(1);
        errorOrRusPhrase.Errors[0].Should().Be(ExerciseErrors.EmptyRusPhrase);
    }
    
    [Fact]
    public void ShouldReturnError_WhenValueIsEmpty()
    {
        var errorOrRusPhrase = RusPhrase.Create("");

        errorOrRusPhrase.IsError.Should().BeTrue();
        errorOrRusPhrase.Errors.Count.Should().Be(1);
        errorOrRusPhrase.Errors[0].Should().Be(ExerciseErrors.EmptyRusPhrase);
    }
    
    [Fact]
    public void ShouldReturnError_WhenValueIsWhiteSpace()
    {
        var errorOrRusPhrase = RusPhrase.Create(" ");

        errorOrRusPhrase.IsError.Should().BeTrue();
        errorOrRusPhrase.Errors.Count.Should().Be(1);
        errorOrRusPhrase.Errors[0].Should().Be(ExerciseErrors.EmptyRusPhrase);
    }
    
    [Fact]
    public void ShouldReturnNewPhrase_WhenValueIsNotEmpty()
    {
        var errorOrRusPhrase = RusPhrase.Create("Моя фраза.");

        errorOrRusPhrase.IsError.Should().BeFalse();
        var rusPhrase = errorOrRusPhrase.Value;
        rusPhrase.Value.Should().Be("Моя фраза.");
    }
}