using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface ICompoundRepository
{
    Task<IReadOnlyList<string>> GetRandomCompounds(Word word, int count, CancellationToken cancellationToken);
}