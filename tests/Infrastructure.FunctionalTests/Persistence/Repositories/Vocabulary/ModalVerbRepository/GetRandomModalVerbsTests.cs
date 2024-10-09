using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.ModalVerbs;
using Domain.Vocabulary.ModalVerbs.ValueObjects;
using FluentAssertions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.ModalVerbRepository;

public class GetRandomModalVerbsTests(FunctionalTestWebAppFactory functionalTestWebAppFactory) : BaseFunctionalTest(functionalTestWebAppFactory)
{
    [Fact]
    public async Task ShouldGetRandomModalVerbTexts_WhenProvidedModalVerbTextWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IModalVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("can").Value, WordType.ModalVerb);
        const int count = 5;

        var modalVerbs = await repository.GetRandomModalVerbsAsync(word, count, CancellationToken.None);
        
        modalVerbs.Should().NotBeNull();
        modalVerbs.Count.Should().Be(count);
        modalVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var modalVerb in modalVerbs)
        {
            if (!await appDbContext.Set<ModalVerb>().AnyAsync(mv => mv.Text == Text.Create(modalVerb).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomModalVerbTexts_WhenProvidedModalVerbTextWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IModalVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("a").Value, WordType.ModalVerb);
        const int count = 5;

        var modalVerbs = await repository.GetRandomModalVerbsAsync(word, count, CancellationToken.None);
        
        modalVerbs.Should().NotBeNull();
        modalVerbs.Count.Should().Be(count);
        modalVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var modalVerb in modalVerbs)
        {
            if (!await appDbContext.Set<ModalVerb>().AnyAsync(mv => mv.Text == Text.Create(modalVerb).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomModalVerbFullNegativeForms_WhenProvidedModalVerbFullNegativeFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IModalVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("can not").Value, WordType.ModalVerb);
        const int count = 5;

        var modalVerbs = await repository.GetRandomModalVerbsAsync(word, count, CancellationToken.None);
        
        modalVerbs.Should().NotBeNull();
        modalVerbs.Count.Should().Be(count);
        modalVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var modalVerb in modalVerbs)
        {
            if (!await appDbContext.Set<ModalVerb>().AnyAsync(mv => mv.FullNegativeForm == FullNegativeForm.Create(modalVerb).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomModalVerbFullNegativeForms_WhenProvidedModalVerbFullNegativeFormWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IModalVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("a not").Value, WordType.ModalVerb);
        const int count = 5;

        var modalVerbs = await repository.GetRandomModalVerbsAsync(word, count, CancellationToken.None);
        
        modalVerbs.Should().NotBeNull();
        modalVerbs.Count.Should().Be(count);
        modalVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var modalVerb in modalVerbs)
        {
            if (!await appDbContext.Set<ModalVerb>().AnyAsync(mv => mv.FullNegativeForm == FullNegativeForm.Create(modalVerb).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomModalVerbShortNegativeForms_WhenProvidedModalVerbShortNegativeFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IModalVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("can't").Value, WordType.ModalVerb);
        const int count = 5;

        var modalVerbs = await repository.GetRandomModalVerbsAsync(word, count, CancellationToken.None);
        
        modalVerbs.Should().NotBeNull();
        modalVerbs.Count.Should().Be(count);
        modalVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var modalVerb in modalVerbs)
        {
            if (!await appDbContext.Set<ModalVerb>().AnyAsync(mv => mv.ShortNegativeForm == ShortNegativeForm.Create(modalVerb).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomModalVerbShortNegativeForms_WhenProvidedModalVerbShortNegativeFormWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IModalVerbRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("an't").Value, WordType.ModalVerb);
        const int count = 5;

        var modalVerbs = await repository.GetRandomModalVerbsAsync(word, count, CancellationToken.None);
        
        modalVerbs.Should().NotBeNull();
        modalVerbs.Count.Should().Be(count);
        modalVerbs.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var modalVerb in modalVerbs)
        {
            if (!await appDbContext.Set<ModalVerb>().AnyAsync(mv => mv.ShortNegativeForm == ShortNegativeForm.Create(modalVerb).Value))
            {
                Assert.Fail();
            }
        }
    }
}