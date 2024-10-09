using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IComparisionAdjectiveRepository
{
    Task<IReadOnlyList<string>> GetRandomComparisonAdjectivesAsync(Word word, int count, CancellationToken cancellationToken);
}