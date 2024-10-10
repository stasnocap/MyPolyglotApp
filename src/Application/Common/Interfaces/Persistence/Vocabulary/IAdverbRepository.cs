using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IAdverbRepository
{
    Task<List<string>> GetRandomAdverbsAsync(Word word, int count, CancellationToken cancellationToken);
}