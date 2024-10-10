using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IComparisonAdjectiveRepository
{
    Task<List<string>> GetRandomComparisonAdjectivesAsync(Word word, int count, CancellationToken cancellationToken);
}