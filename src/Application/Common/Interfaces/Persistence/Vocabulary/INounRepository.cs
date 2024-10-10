using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface INounRepository
{
    Task<List<string>> GetRandomNounsAsync(Word word, int count, CancellationToken cancellationToken);
}