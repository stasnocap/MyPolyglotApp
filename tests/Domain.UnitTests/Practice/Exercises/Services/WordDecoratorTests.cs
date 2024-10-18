using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.Services;
using Domain.Practice.Exercises.ValueObjects;
using FluentAssertions;

namespace Domain.UnitTests.Practice.Exercises.Services;

public class WordDecoratorTests
{
    [Fact]
    public void ShouldMakeFirstLetterUpperCase_IfWordHasFirstLetterUppercased()
    {
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("My").Value, WordType.Adjective);
        var words = new List<string>()
        {
            "old",
            "new",
            "granny",
        };
        
        WordDecorator.Decorate(word, words);
        
        foreach (var w in words)
        {
            char.IsUpper(w[0]).Should().BeTrue();
        }
    }
    
    [Fact]
    public void ShouldAppendNonWordSymbol_IfWordHasNonWordSymbolAtTheEnd()
    {
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("my.").Value, WordType.Adjective);
        var words = new List<string>()
        {
            "old",
            "new",
            "granny",
        };
        
        WordDecorator.Decorate(word, words);
        
        foreach (var w in words)
        {
            (w[^1] == '.').Should().BeTrue();
        }
    }
    
    [Fact]
    public void ShouldDoNothing_IfWordHasNonWordSymbolInTheMiddle()
    {
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("didn't").Value, WordType.Adjective);
        var source = new List<string>()
        {
            "old",
            "new",
            "granny",
        };
        
        var decorated = new List<string>()
        {
            "old",
            "new",
            "granny",
        };
        
        WordDecorator.Decorate(word, decorated);

        source.SequenceEqual(decorated).Should().BeTrue();
    }
}