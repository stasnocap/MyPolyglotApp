using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IModalVerbRepository
{
    Task<IReadOnlyList<string>> GetRandomModalVerbsAsync(Word word, int count, CancellationToken cancellationToken);
}