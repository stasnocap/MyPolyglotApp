using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface ILetterNumberRepository
{
    Task<List<string>> GetRandomLetterNumbersAsync(Word word, int count, CancellationToken cancellationToken);
}