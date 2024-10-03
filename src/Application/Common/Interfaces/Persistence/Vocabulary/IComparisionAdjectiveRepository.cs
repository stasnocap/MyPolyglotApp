using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IComparisionAdjectiveRepository
{
    Task<IReadOnlyList<string>> GetRandomComparisonAdjectives(Word word, int count, CancellationToken cancellationToken);
}