using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Vocabulary.Compounds;
using Domain.Vocabulary.Compounds.ValueObjects;
using FluentAssertions;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Extensions.Queryable;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.CompoundRepository;

public class GetRandomCompoundsTests(FunctionalTestWebAppFactory factory) : BaseFunctionalTest(factory)
{
    [Theory]
    [InlineData("something", CompoundType.Some)]
    [InlineData("anything", CompoundType.Any)]
    [InlineData("everything", CompoundType.Every)]
    [InlineData("nothing", CompoundType.No)]
    public async Task ShouldGetRandomCompoundsByType_WhenProvidedCompoundWhichIsExistsInDatabase(string text, CompoundType type)
    {
        var repository = Services.GetRequiredService<ICompoundRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create(text).Value, WordType.Compound);
        const int count = 5;
        
        var compounds = await repository.GetRandomCompoundsAsync(word, count, CancellationToken.None);
        
        compounds.Should().NotBeNull();
        compounds.Count.Should().Be(count);
        compounds.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();

        var typeCount = await appDbContext.Set<Compound>().CountAsync(c => c.Type == type);

        foreach (var compound in compounds)
        {
            if (!await appDbContext.Set<Compound>()
                    .WhereIf(typeCount > count, c => c.Type == type)
                    .AnyAsync(c => c.Text == Text.Create(compound).Value))
            {
                Assert.Fail();
            }
        }
    }

    [Fact]
    public async Task ShouldGetRandomCompounds_WhenProvidedAnyText()
    {
        var repository = Services.GetRequiredService<ICompoundRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("a").Value, WordType.Compound);
        const int count = 5;
        
        var compounds = await repository.GetRandomCompoundsAsync(word, count, CancellationToken.None);
        
        compounds.Should().NotBeNull();
        compounds.Count.Should().Be(count);
        compounds.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();

        foreach (var compound in compounds)
        {
            if (!await appDbContext.Set<Compound>().AnyAsync(c => c.Text == Text.Create(compound).Value))
            {
                Assert.Fail();
            }
        }
    }
}