using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface ILetterNumberRepository
{
    Task<IReadOnlyList<string>> GetRandomLetterNumbersAsync(Word word, int count, CancellationToken cancellationToken);
}