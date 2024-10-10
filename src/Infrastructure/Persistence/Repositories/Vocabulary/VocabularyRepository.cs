using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class VocabularyRepository(
    AppDbContext _dbContext,
    IComparisonAdjectiveRepository comparisonAdjectiveRepository,
    ILetterNumberRepository _letterNumberRepository,
    IModalVerbRepository _modalVerbRepository,
    INounRepository _nounRepository,
    IPrimaryVerbRepository _primaryVerbRepository,
    IAdverbRepository _adverbRepository,
    ICompoundRepository _compoundRepository,
    IVerbRepository _verbRepository,
    INumberWithNounRepository _numberWithNounRepository) : IVocabularyRepository
{
    public async Task<List<string>> GetRandomAsync(Word word, int count, CancellationToken cancellationToken)
    {
        switch (word.Type)
        {
            case WordType.Adjective:
            case WordType.City:
            case WordType.Determiner:
            case WordType.Language:
            case WordType.Preposition:
            case WordType.Pronoun:
            case WordType.QuestionWord:
                var wordType = WordTypes.GetWordType(word.Type);

                var words = await _dbContext.GetAll(wordType)
                    .AsNoTracking()
                    .Where(w => word.Text.GetWord() != EF.Property<Text>(w, "Text"))
                    .OrderBy(w => Guid.NewGuid())
                    .Take(count)
                    .ToListAsync(cancellationToken);

                var textProperty = wordType.GetProperty("Text")!;

                return words.Select(x => ((Text)textProperty.GetValue(x)!).Value).ToList();
            case WordType.Adverb:
                return await _adverbRepository.GetRandomAdverbsAsync(word, count, cancellationToken);
            case WordType.Compound:
                return await _compoundRepository.GetRandomCompoundsAsync(word, count, cancellationToken);
            case WordType.ComparisonAdjective:
                return await comparisonAdjectiveRepository.GetRandomComparisonAdjectivesAsync(word, count, cancellationToken);
            case WordType.LetterNumber:
                return await _letterNumberRepository.GetRandomLetterNumbersAsync(word, count, cancellationToken);
            case WordType.ModalVerb:
                return await _modalVerbRepository.GetRandomModalVerbsAsync(word, count, cancellationToken);
            case WordType.Noun:
                return await _nounRepository.GetRandomNounsAsync(word, count, cancellationToken);
            case WordType.PrimaryVerb:
                return await _primaryVerbRepository.GetRandomPrimaryVerbsAsync(word, count, cancellationToken);
            case WordType.Verb:
                return await _verbRepository.GetRandomVerbsAsync(word, count, cancellationToken);
            case WordType.NumberWithNoun:
                return await _numberWithNounRepository.GetRandomNumberWithNounsAsync(word, count, cancellationToken);
            case WordType.None:
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}