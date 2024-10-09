using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.Verbs;
using FluentAssertions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.VerbRepository;

public class GetRandomVerbsTests(FunctionalTestWebAppFactory functionalTestWebAppFactory) : BaseFunctionalTest(functionalTestWebAppFactory)
{
    [Fact]
    public async Task ShouldGetRandomVerbTexts_WhenProvidedVerbTextWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("abide").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv => pv.Text ==  verbText))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomVerbTexts_WhenProvidedVerbTextWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("bark").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv => pv.Text ==  verbText))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomVerbPastForms_WhenProvidedVerbPastFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("abode").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv =>(string)pv.PastForm == (string)verbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomVerbPastForms_WhenProvidedVerbPastFormWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("barked").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv => (string)pv.PastForm == (string)verbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomVerbPastParticipleForms_WhenProvidedVerbPastParticipleFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("barked").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv => (string)pv.PastForm == (string)verbText || (string)pv.PastParticipleForm == (string)verbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomVerbPastParticipleForms_WhenProvidedVerbPastParticipleFormWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("barked").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv => (string)pv.PastForm == (string)verbText || (string)pv.PastParticipleForm == (string)verbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomVerbPresentParticipleForms_WhenProvidedVerbPresentParticipleFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("barking").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv => (string)pv.PresentParticipleForm == (string)verbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomVerbPresentParticipleForms_WhenProvidedVerbPresentParticipleFormWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("barking").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv => (string)pv.PresentParticipleForm == (string)verbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomVerbThirdPersonForms_WhenProvidedVerbThirdPersonFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("barks").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv => (string)pv.ThirdPersonForm == (string)verbText))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomVerbThirdPersonForms_WhenProvidedVerbThirdPersonFormWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("barks").Value, WordType.Verb);
        const int count = 5;

        var verbs = await repository.GetRandomVerbsAsync(word, count, CancellationToken.None);
        
        verbs.Should().NotBeNull();
        verbs.Count.Should().Be(count);
        verbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var verb in verbs)
        {
            var verbText = Text.Create(verb).Value;
            if (!await appDbContext.Set<Verb>().AnyAsync(pv => (string)pv.ThirdPersonForm == (string)verbText))
            {
                Assert.Fail();
            }
        }
    }
}