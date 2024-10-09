using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.FunctionalTests.Abstractions;
using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using FluentAssertions;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.VocabularyRepository;

public class GetRandomTests(FunctionalTestWebAppFactory functionalTestWebAppFactory) : BaseFunctionalTest(functionalTestWebAppFactory)
{
    [Theory]
    [InlineData(WordType.Adjective)]
    [InlineData(WordType.City)]
    [InlineData(WordType.Determiner)]
    [InlineData(WordType.Language)]
    [InlineData(WordType.Preposition)]
    [InlineData(WordType.Pronoun)]
    [InlineData(WordType.QuestionWord)]
    public async Task ShouldGetRandomWordsByType_WhenProvidedWordWithType(WordType type)
    {
        var repository = Services.GetRequiredService<IVocabularyRepository>();
        var word = Word.Create(ExerciseId.CreateUnique(), WordNumber.Create(1).Value, Text.Create("someword").Value, type);
        const int count = 5;
        
        var words = await repository.GetRandomAsync(word, count, CancellationToken.None);
        
        words.Should().NotBeNull();
        if (type != WordType.Determiner)
        {
            words.Count.Should().Be(count);
        }
        words.Should().NotContain(word.Text.Value);
        
        var appDbContext = Services.GetRequiredService<AppDbContext>();
        foreach (var adverb in words)
        {
            var wordType = WordTypes.GetWordType(word.Type);

            if (!await appDbContext.GetAll(wordType).AnyAsync(w => EF.Property<Text>(w, "Text") == Text.Create(adverb).Value))
            {
                Assert.Fail();
            }
        }
    }
}