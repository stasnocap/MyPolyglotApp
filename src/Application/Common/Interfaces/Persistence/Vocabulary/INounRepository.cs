using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface INounRepository
{
    Task<IReadOnlyList<string>> GetRandomNounsAsync(Word word, int count, CancellationToken cancellationToken);
}