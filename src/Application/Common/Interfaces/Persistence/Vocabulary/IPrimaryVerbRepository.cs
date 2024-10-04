using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IPrimaryVerbRepository
{
    Task<IReadOnlyList<string>> GetRandomPrimaryVerbs(Word word, int count, CancellationToken cancellationToken);
}