using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.LetterNumbers;
using FluentAssertions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.LetterNumberRepository;

public class GetRandomLetterNumbersTests(FunctionalTestWebAppFactory factory) : BaseFunctionalTest(factory)
{
    [Fact]
    public async Task ShouldGetNearestLetterNumbers_WhenProvidedLetterNumberWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<ILetterNumberRepository>();
        var wordNumber = 25;
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("twenty-five").Value, WordType.LetterNumber);
        const int count = 5;
        
        var letterNumbers = await repository.GetRandomLetterNumbersAsync(word, count, CancellationToken.None);
        
        letterNumbers.Should().NotBeNull();
        letterNumbers.Count.Should().Be(count);
        letterNumbers.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        var halfOfACount = Math.Ceiling(count / 2.0);
        foreach (var letterNumberStr in letterNumbers)
        {
            var letterNumber = await appDbContext.Set<LetterNumber>().FirstOrDefaultAsync(a => a.Text == Text.Create(letterNumberStr).Value);
            
            letterNumber.Should().NotBeNull();
            (wordNumber - halfOfACount <= letterNumber!.Number.Value && letterNumber.Number.Value <= wordNumber + halfOfACount).Should().BeTrue();
        }
    }
    
    [Fact]
    public async Task ShouldGetNearestLetterNumbersAndFillUpIfWithRandoms_WhenProvidedLetterNumberWhichIsExistsInDatabaseButNearTheEdge()
    {
        var repository = Services.GetRequiredService<ILetterNumberRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("ninety-nine").Value, WordType.LetterNumber);
        const int count = 5;
        
        var letterNumbers = await repository.GetRandomLetterNumbersAsync(word, count, CancellationToken.None);
        
        letterNumbers.Should().NotBeNull();
        letterNumbers.Count.Should().Be(count);
        letterNumbers.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var letterNumber in letterNumbers)
        {
            if (!await appDbContext.Set<LetterNumber>().AnyAsync(a => a.Text == Text.Create(letterNumber).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomLetterNumbers_WhenProvidedLetterNumberWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<ILetterNumberRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("a").Value, WordType.LetterNumber);
        const int count = 5;
        
        var letterNumbers = await repository.GetRandomLetterNumbersAsync(word, count, CancellationToken.None);
        
        letterNumbers.Should().NotBeNull();
        letterNumbers.Count.Should().Be(count);
        letterNumbers.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var letterNumber in letterNumbers)
        {
            if (!await appDbContext.Set<LetterNumber>().AnyAsync(a => a.Text == Text.Create(letterNumber).Value))
            {
                Assert.Fail();
            }
        }
    }
}