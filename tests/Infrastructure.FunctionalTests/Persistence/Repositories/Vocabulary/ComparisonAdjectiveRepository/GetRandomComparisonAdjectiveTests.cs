using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.ComparisonAdjectives;
using Domain.Vocabulary.ComparisonAdjectives.ValueObjects;
using FluentAssertions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.ComparisonAdjectiveRepository;

public class GetRandomComparisonAdjectiveTests(FunctionalTestWebAppFactory functionalTestWebAppFactory) : BaseFunctionalTest(functionalTestWebAppFactory)
{
    [Fact]
    public async Task ShouldGetRandomComparisonAdjectiveTexts_WhenProvidedComparisonAdjectiveTextWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IComparisonAdjectiveRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("good").Value, WordType.ComparisonAdjective);
        const int count = 5;

        var comparisonAdjectives = await repository.GetRandomComparisonAdjectivesAsync(word, count, CancellationToken.None);
        
        comparisonAdjectives.Should().NotBeNull();
        comparisonAdjectives.Count.Should().Be(count);
        comparisonAdjectives.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var comparisonAdjective in comparisonAdjectives)
        {
            if (!await appDbContext.Set<ComparisonAdjective>().AnyAsync(ca => ca.Text == Text.Create(comparisonAdjective).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomComparisonAdjectiveTexts_WhenProvidedComparisonAdjectiveTextWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IComparisonAdjectiveRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("sad").Value, WordType.ComparisonAdjective);
        const int count = 5;

        var comparisonAdjectives = await repository.GetRandomComparisonAdjectivesAsync(word, count, CancellationToken.None);
        
        comparisonAdjectives.Should().NotBeNull();
        comparisonAdjectives.Count.Should().Be(count);
        comparisonAdjectives.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var comparisonAdjective in comparisonAdjectives)
        {
            if (!await appDbContext.Set<ComparisonAdjective>().AnyAsync(ca => ca.Text == Text.Create(comparisonAdjective).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomComparisonAdjectiveComparativeForms_WhenProvidedComparisonAdjectiveComparativeFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IComparisonAdjectiveRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("larger").Value, WordType.ComparisonAdjective);
        const int count = 5;

        var comparisonAdjectives = await repository.GetRandomComparisonAdjectivesAsync(word, count, CancellationToken.None);
        
        comparisonAdjectives.Should().NotBeNull();
        comparisonAdjectives.Count.Should().Be(count);
        comparisonAdjectives.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var comparisonAdjective in comparisonAdjectives)
        {
            if (!await appDbContext.Set<ComparisonAdjective>().AnyAsync(ca => ca.ComparativeForm == ComparativeForm.Create(comparisonAdjective).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Theory]
    [InlineData("sadder")]
    [InlineData("more important")]
    public async Task ShouldGetRandomComparisonAdjectiveComparativeForms_WhenProvidedComparisonAdjectiveComparativeFormWhichIsNotExistsInDatabase(string text)
    {
        var repository = Services.GetRequiredService<IComparisonAdjectiveRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create(text).Value, WordType.ComparisonAdjective);
        const int count = 5;

        var comparisonAdjectives = await repository.GetRandomComparisonAdjectivesAsync(word, count, CancellationToken.None);
        
        comparisonAdjectives.Should().NotBeNull();
        comparisonAdjectives.Count.Should().Be(count);
        comparisonAdjectives.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var comparisonAdjective in comparisonAdjectives)
        {
            if (!await appDbContext.Set<ComparisonAdjective>().AnyAsync(ca => ca.ComparativeForm == ComparativeForm.Create(comparisonAdjective).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Fact]
    public async Task ShouldGetRandomComparisonAdjectiveSuperlativeForms_WhenProvidedComparisonAdjectiveSuperlativeFormWhichIsExistsInDatabase()
    {
        var repository = Services.GetRequiredService<IComparisonAdjectiveRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("largest").Value, WordType.ComparisonAdjective);
        const int count = 5;

        var comparisonAdjectives = await repository.GetRandomComparisonAdjectivesAsync(word, count, CancellationToken.None);
        
        comparisonAdjectives.Should().NotBeNull();
        comparisonAdjectives.Count.Should().Be(count);
        comparisonAdjectives.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var comparisonAdjective in comparisonAdjectives)
        {
            if (!await appDbContext.Set<ComparisonAdjective>().AnyAsync(ca => ca.SuperlativeForm == SuperlativeForm.Create(comparisonAdjective).Value))
            {
                Assert.Fail();
            }
        }
    }
    
    [Theory]
    [InlineData("saddest")]
    [InlineData("most important")]
    public async Task ShouldGetRandomComparisonAdjectiveSuperlativeForms_WhenProvidedComparisonAdjectiveSuperlativeFormWhichIsNotExistsInDatabase(string text)
    {
        var repository = Services.GetRequiredService<IComparisonAdjectiveRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create(text).Value, WordType.ComparisonAdjective);
        const int count = 5;

        var comparisonAdjectives = await repository.GetRandomComparisonAdjectivesAsync(word, count, CancellationToken.None);
        
        comparisonAdjectives.Should().NotBeNull();
        comparisonAdjectives.Count.Should().Be(count);
        comparisonAdjectives.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var comparisonAdjective in comparisonAdjectives)
        {
            if (!await appDbContext.Set<ComparisonAdjective>().AnyAsync(ca => ca.SuperlativeForm == SuperlativeForm.Create(comparisonAdjective).Value))
            {
                Assert.Fail();
            }
        }
    }
}