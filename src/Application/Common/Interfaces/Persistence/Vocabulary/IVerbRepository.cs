using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IVerbRepository
{
    Task<IReadOnlyList<string>> GetRandomVerbsAsync(Word word, int count, CancellationToken cancellationToken);
}