using System.Text.RegularExpressions;
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

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.NumberWithNounRepository;

public class GetRandomNumberWithNouns(FunctionalTestWebAppFactory functionalTestWebAppFactory) : BaseFunctionalTest(functionalTestWebAppFactory)
{
    [Fact]
    public async Task ShouldGetRandomNumberWithNounPluralForms_WhenProvidedNumberWithNounPluralFormWhichIsNotExistsInDatabase()
    {
        var repository = Services.GetRequiredService<INumberWithNounRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("5 dogs").Value, WordType.NumberWithNoun);
        const int count = 5;

        var numberWithNouns = await repository.GetRandomNumberWithNounsAsync(word, count, CancellationToken.None);

        numberWithNouns.Should().NotBeNull();
        numberWithNouns.Count.Should().Be(count);
        numberWithNouns.Should().NotContain(word.Text.Value);

        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var numberWithNoun in numberWithNouns)
        {
            var noun = Regex.Match(numberWithNoun, "[a-zA-Z]+");

            if (!await appDbContext.Set<Noun>().AnyAsync(n => n.PluralForm == PluralForm.Create(noun.Value).Value))
            {
                Assert.Fail();
            }
        }
    }
}