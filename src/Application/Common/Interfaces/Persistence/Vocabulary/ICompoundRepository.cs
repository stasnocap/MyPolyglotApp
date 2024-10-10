using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface ICompoundRepository
{
    Task<List<string>> GetRandomCompoundsAsync(Word word, int count, CancellationToken cancellationToken);
}