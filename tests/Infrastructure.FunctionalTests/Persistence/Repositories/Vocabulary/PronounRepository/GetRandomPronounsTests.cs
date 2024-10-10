using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.Pronouns;
using Domain.Vocabulary.Pronouns.ValueObjects;
using FluentAssertions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.PronounRepository;

public class GetRandomPronounsTests(FunctionalTestWebAppFactory factory) : BaseFunctionalTest(factory)
{
    [Theory]
    [InlineData("i", PronounType.Subject)]
    [InlineData("me", PronounType.Object)]
    [InlineData("my", PronounType.PossessiveAdjective)]
    [InlineData("mine", PronounType.Possessive)]
    [InlineData("myself", PronounType.Reflexive)]
    [InlineData("this", PronounType.Demonstrative)]
    public async Task ShouldGetRandomPronounsByType_WhenProvidedPronounWhichIsExistsInDatabase(string text, PronounType type)
    {
        var repository = Services.GetRequiredService<IPronounRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create(text).Value, WordType.Pronoun);
        const int count = 5;
        
        var pronouns = await repository.GetRandomPronounsAsync(word, count, CancellationToken.None);
        
        pronouns.Should().NotBeNull();
        pronouns.Count.Should().Be(count);
        pronouns.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var pronoun in pronouns)
        {
            if (!await appDbContext.Set<Pronoun>().AnyAsync(a => a.Text == Text.Create(pronoun).Value))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomPronouns_WhenProvidedAnyText()
    {
        var repository = Services.GetRequiredService<IPronounRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("a").Value, WordType.Pronoun);
        const int count = 5;
        
        var pronouns = await repository.GetRandomPronounsAsync(word, count, CancellationToken.None);
        
        pronouns.Should().NotBeNull();
        pronouns.Count.Should().Be(count);
        pronouns.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var pronoun in pronouns)
        {
            if (!await appDbContext.Set<Pronoun>().AnyAsync(a => a.Text == Text.Create(pronoun).Value))
            {
                Assert.Fail();
            }
        }
    }
}