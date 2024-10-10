using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IModalVerbRepository
{
    Task<List<string>> GetRandomModalVerbsAsync(Word word, int count, CancellationToken cancellationToken);
}