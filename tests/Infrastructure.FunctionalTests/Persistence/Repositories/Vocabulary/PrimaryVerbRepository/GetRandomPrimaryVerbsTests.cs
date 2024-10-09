using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.PrimaryVerbs;
using FluentAssertions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.PrimaryVerbRepository;

public class GetRandomPrimaryVerbsTests(FunctionalTestWebAppFactory functionalTestWebAppFactory) : BaseFunctionalTest(functionalTestWebAppFactory)
{
    [Fact]
    public async Task ShouldGetRandomPrimaryVerbTexts_WhenProvidedPrimaryVerbTextWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IPrimaryVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("do").Value, WordType.PrimaryVerb);
        const int count = 5;

        var primaryVerbs = await repository.GetRandomPrimaryVerbsAsync(word, count, CancellationToken.None);
        
        primaryVerbs.Should().NotBeNull();
        primaryVerbs.Count.Should().Be(count);
        primaryVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var primaryVerb in primaryVerbs)
        {
            var primaryVerbText = Text.Create(primaryVerb).Value;
            if (!await appDbContext.Set<PrimaryVerb>().AnyAsync(pv => pv.Text ==  primaryVerbText || (string)pv.PastForm == (string)primaryVerbText))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomPrimaryVerbTexts_WhenProvidedPrimaryVerbTextWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IPrimaryVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("a").Value, WordType.PrimaryVerb);
        const int count = 5;

        var primaryVerbs = await repository.GetRandomPrimaryVerbsAsync(word, count, CancellationToken.None);
        
        primaryVerbs.Should().NotBeNull();
        primaryVerbs.Count.Should().Be(count);
        primaryVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var primaryVerb in primaryVerbs)
        {
            var primaryVerbText = Text.Create(primaryVerb).Value;
            if (!await appDbContext.Set<PrimaryVerb>().AnyAsync(pv => pv.Text ==  primaryVerbText || (string)pv.PastForm == (string)primaryVerbText))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomPrimaryVerbPastForms_WhenProvidedPrimaryVerbPastFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IPrimaryVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("did").Value, WordType.PrimaryVerb);
        const int count = 5;

        var primaryVerbs = await repository.GetRandomPrimaryVerbsAsync(word, count, CancellationToken.None);
        
        primaryVerbs.Should().NotBeNull();
        primaryVerbs.Count.Should().Be(count);
        primaryVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var primaryVerb in primaryVerbs)
        {
            var primaryVerbText = Text.Create(primaryVerb).Value;
            if (!await appDbContext.Set<PrimaryVerb>().AnyAsync(pv => pv.Text ==  primaryVerbText || (string)pv.PastForm == (string)primaryVerbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomPrimaryVerbPastParticipleForms_WhenProvidedPrimaryVerbPastParticipleFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IPrimaryVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("done").Value, WordType.PrimaryVerb);
        const int count = 5;

        var primaryVerbs = await repository.GetRandomPrimaryVerbsAsync(word, count, CancellationToken.None);
        
        primaryVerbs.Should().NotBeNull();
        primaryVerbs.Count.Should().Be(count);
        primaryVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var primaryVerb in primaryVerbs)
        {
            var primaryVerbText = Text.Create(primaryVerb).Value;
            if (!await appDbContext.Set<PrimaryVerb>().AnyAsync(pv => pv.Text ==  primaryVerbText || (string)pv.PastParticipleForm == (string)primaryVerbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomPrimaryVerbPresentParticipleForms_WhenProvidedPrimaryVerbPresentParticipleFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IPrimaryVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("doing").Value, WordType.PrimaryVerb);
        const int count = 5;

        var primaryVerbs = await repository.GetRandomPrimaryVerbsAsync(word, count, CancellationToken.None);
        
        primaryVerbs.Should().NotBeNull();
        primaryVerbs.Count.Should().Be(count);
        primaryVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var primaryVerb in primaryVerbs)
        {
            var primaryVerbText = Text.Create(primaryVerb).Value;
            if (!await appDbContext.Set<PrimaryVerb>().AnyAsync(pv => pv.Text ==  primaryVerbText || (string)pv.PresentParticipleForm == (string)primaryVerbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomPrimaryVerbThirdPersonForms_WhenProvidedPrimaryVerbThirdPersonFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IPrimaryVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("does").Value, WordType.PrimaryVerb);
        const int count = 5;

        var primaryVerbs = await repository.GetRandomPrimaryVerbsAsync(word, count, CancellationToken.None);
        
        primaryVerbs.Should().NotBeNull();
        primaryVerbs.Count.Should().Be(count);
        primaryVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var primaryVerb in primaryVerbs)
        {
            var primaryVerbText = Text.Create(primaryVerb).Value;
            if (!await appDbContext.Set<PrimaryVerb>().AnyAsync(pv => pv.Text ==  primaryVerbText || (string)pv.ThirdPersonForm == (string)primaryVerbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomPrimaryVerbFullNegativeForms_WhenProvidedPrimaryVerbFullNegativeFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IPrimaryVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("do not").Value, WordType.PrimaryVerb);
        const int count = 5;

        var primaryVerbs = await repository.GetRandomPrimaryVerbsAsync(word, count, CancellationToken.None);
        
        primaryVerbs.Should().NotBeNull();
        primaryVerbs.Count.Should().Be(count);
        primaryVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var primaryVerb in primaryVerbs)
        {
            if (!await appDbContext.Set<PrimaryVerb>().AnyAsync(pv => pv.FullNegativeForms.Any(fnf => fnf.Value == primaryVerb)))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomPrimaryVerbShortNegativeForms_WhenProvidedPrimaryVerbShortNegativeFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IPrimaryVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("don't").Value, WordType.PrimaryVerb);
        const int count = 5;

        var primaryVerbs = await repository.GetRandomPrimaryVerbsAsync(word, count, CancellationToken.None);
        
        primaryVerbs.Should().NotBeNull();
        primaryVerbs.Count.Should().Be(count);
        primaryVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var primaryVerb in primaryVerbs)
        {
            if (!await appDbContext.Set<PrimaryVerb>().AnyAsync(pv => pv.ShortNegativeForms.Any(fnf => fnf.Value == primaryVerb)))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomPrimaryVerbAdditionalForms_WhenProvidedPrimaryVerbAdditionalFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IPrimaryVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("were").Value, WordType.PrimaryVerb);
        const int count = 5;

        var primaryVerbs = await repository.GetRandomPrimaryVerbsAsync(word, count, CancellationToken.None);
        
        primaryVerbs.Should().NotBeNull();
        primaryVerbs.Count.Should().Be(count);
        primaryVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var primaryVerb in primaryVerbs)
        {
            var primaryVerbText = Text.Create(primaryVerb).Value;
            if (!await appDbContext.Set<PrimaryVerb>().AnyAsync(pv => pv.Text ==  primaryVerbText || pv.AdditionalForms.Any(fnf => fnf.Value == primaryVerb)))
            {
                Assert.Fail();
            }
        }
    }
}