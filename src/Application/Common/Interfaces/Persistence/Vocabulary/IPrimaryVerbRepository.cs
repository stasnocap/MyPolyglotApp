using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IPrimaryVerbRepository
{
    Task<IReadOnlyList<string>> GetRandomPrimaryVerbsAsync(Word word, int count, CancellationToken cancellationToken);
}