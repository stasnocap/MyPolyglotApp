using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class VocabularyRepository(
    AppDbContext _dbContext,
    IComparisionAdjectiveRepository _comparisionAdjectiveRepository,
    ILetterNumberRepository _letterNumberRepository,
    IModalVerbRepository _modalVerbRepository,
    INounRepository _nounRepository,
    IPrimaryVerbRepository _primaryVerbRepository,
    IAdverbRepository _adverbRepository,
    ICompoundRepository _compoundRepository) : IVocabularyRepository
{
    public async Task<IReadOnlyList<string>> GetRandomAsync(Word word, int count, CancellationToken cancellationToken)
    {
        switch (word.Type)
        {
            case WordType.Adjective:
            case WordType.City:
            case WordType.Determiner:
            case WordType.Language:
            case WordType.NumberWithNoun:
            case WordType.Preposition:
            case WordType.Pronoun:
            case WordType.QuestionWord:
                var wordType = WordTypes.GetWordType(word.Type);

                var words = await _dbContext.GetAll(wordType)
                    .AsNoTracking()
                    .Where(x => !word.Text.Value.ToLower().Contains((string)EF.Property<Text>(x, "Text")))
                    .OrderBy(x => Guid.NewGuid())
                    .Take(count)
                    .ToListAsync(cancellationToken);

                var textProperty = wordType.GetProperty("Text")!;

                return words.Select(x => ((Text)textProperty.GetValue(x)!).Value).ToList();
            case WordType.Adverb:
                return await _adverbRepository.GetRandomAdverbs(word, count, cancellationToken);
            case WordType.Compound:
                return await _compoundRepository.GetRandomCompounds(word, count, cancellationToken);
            case WordType.ComparisonAdjective:
                return await _comparisionAdjectiveRepository.GetRandomComparisonAdjectives(word, count, cancellationToken);
            case WordType.LetterNumber:
                return await _letterNumberRepository.GetRandomLetterNumbers(word, count, cancellationToken);
            case WordType.ModalVerb:
                return await _modalVerbRepository.GetRandomModalVerbs(word, count, cancellationToken);
            case WordType.Noun:
                return await _nounRepository.GetRandomNouns(word, count, cancellationToken);
            case WordType.PrimaryVerb:
                return await _primaryVerbRepository.GetRandomPrimaryVerbs(word, count, cancellationToken);
            case WordType.Verb:
                return await _primaryVerbRepository.GetRandomPrimaryVerbs(word, count, cancellationToken);
            case WordType.None:
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}