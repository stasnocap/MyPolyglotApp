using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IAdverbRepository
{
    Task<IReadOnlyList<string>> GetRandomAdverbsAsync(Word word, int count, CancellationToken cancellationToken);
}