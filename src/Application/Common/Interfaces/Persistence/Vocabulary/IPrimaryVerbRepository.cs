using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IPrimaryVerbRepository
{
    Task<List<string>> GetRandomPrimaryVerbsAsync(Word word, int count, CancellationToken cancellationToken);
}