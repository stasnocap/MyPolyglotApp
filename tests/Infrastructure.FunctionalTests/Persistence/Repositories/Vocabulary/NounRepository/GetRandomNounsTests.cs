using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.Nouns;
using Domain.Vocabulary.Nouns.ValueObjects;
using FluentAssertions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.NounRepository;

public class GetRandomNounsTests(FunctionalTestWebAppFactory functionalTestWebAppFactory) : BaseFunctionalTest(functionalTestWebAppFactory)
{
    [Fact]
    public async Task ShouldGetRandomNounTexts_WhenProvidedNounTextWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<INounRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("addendum").Value, WordType.Noun);
        const int count = 5;

        var nouns = await repository.GetRandomNounsAsync(word, count, CancellationToken.None);
        
        nouns.Should().NotBeNull();
        nouns.Count.Should().Be(count);
        nouns.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var noun in nouns)
        {
            if (!await appDbContext.Set<Noun>().AnyAsync(n => n.Text == Text.Create(noun).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomNounTexts_WhenProvidedNounTextWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<INounRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("dog").Value, WordType.Noun);
        const int count = 5;

        var nouns = await repository.GetRandomNounsAsync(word, count, CancellationToken.None);
        
        nouns.Should().NotBeNull();
        nouns.Count.Should().Be(count);
        nouns.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var noun in nouns)
        {
            if (!await appDbContext.Set<Noun>().AnyAsync(n => n.Text == Text.Create(noun).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomNounFullNegativeForms_WhenProvidedNounFullNegativeFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<INounRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("addenda").Value, WordType.Noun);
        const int count = 5;

        var nouns = await repository.GetRandomNounsAsync(word, count, CancellationToken.None);
        
        nouns.Should().NotBeNull();
        nouns.Count.Should().Be(count);
        nouns.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var noun in nouns)
        {
            if (!await appDbContext.Set<Noun>().AnyAsync(n => n.PluralForm == PluralForm.Create(noun).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomNounFullNegativeForms_WhenProvidedNounFullNegativeFormWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<INounRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("dogs").Value, WordType.Noun);
        const int count = 5;

        var nouns = await repository.GetRandomNounsAsync(word, count, CancellationToken.None);
        
        nouns.Should().NotBeNull();
        nouns.Count.Should().Be(count);
        nouns.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var noun in nouns)
        {
            if (!await appDbContext.Set<Noun>().AnyAsync(n => n.PluralForm == PluralForm.Create(noun).Value))
            {
                Assert.Fail();
            }
        }
    }
}