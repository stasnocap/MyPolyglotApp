using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IAdverbRepository
{
    Task<IReadOnlyList<string>> GetRandomAdverbs(Word word, int count, CancellationToken cancellationToken);
}