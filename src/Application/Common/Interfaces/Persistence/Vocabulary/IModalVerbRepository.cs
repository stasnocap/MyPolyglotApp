using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IModalVerbRepository
{
    Task<IReadOnlyList<string>> GetRandomModalVerbs(Word word, int count, CancellationToken cancellationToken);
}