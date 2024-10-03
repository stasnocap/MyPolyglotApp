using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IVocabularyRepository
{
    Task<IReadOnlyList<string>> GetRandomAsync(Word word, int count, CancellationToken cancellationToken);
}