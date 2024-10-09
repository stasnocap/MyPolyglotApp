using System.Linq.Expressions;
using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.Adverbs;
using Domain.Vocabulary.Adverbs.ValueObjects;
using FluentAssertions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.AdverbRepository;

public class GetRandomAdverbsTests(FunctionalTestWebAppFactory factory) : BaseFunctionalTest(factory)
{
    [Theory]
    [InlineData("again", AdverbType.Frequency)]
    [InlineData("literally", AdverbType.Intensifier)]
    [InlineData("beautifully", AdverbType.Manner)]
    [InlineData("briskly", AdverbType.TellHowItHappened)]
    [InlineData("here", AdverbType.TellWhereItHappened)]
    [InlineData("early", AdverbType.TellWhenItHappened)]
    [InlineData("almost", AdverbType.TellTheExtentOfTheAction)]
    public async Task ShouldGetRandomAdverbsByType_WhenProvidedAdverbWhichIsExistsInDatabase(string text, AdverbType type)
    {
        var adverbRepository = Services.GetRequiredService<IAdverbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create(text).Value, WordType.Adverb);
        const int count = 5;
        
        var adverbs = await adverbRepository.GetRandomAdverbsAsync(word, count, CancellationToken.None);
        
        adverbs.Should().NotBeNull();
        adverbs.Count.Should().Be(count);
        adverbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var adverb in adverbs)
        {
            if (!await appDbContext.Set<Adverb>().AnyAsync(a => a.Text == Text.Create(adverb).Value && a.Type == type))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomAdverbs_WhenProvidedAnyText()
    {
        var adverbRepository = Services.GetRequiredService<IAdverbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("a").Value, WordType.Adverb);
        const int count = 5;
        
        var adverbs = await adverbRepository.GetRandomAdverbsAsync(word, count, CancellationToken.None);
        
        adverbs.Should().NotBeNull();
        adverbs.Count.Should().Be(count);
        adverbs.Should().NotContain(word.Text.Value);
    }
}