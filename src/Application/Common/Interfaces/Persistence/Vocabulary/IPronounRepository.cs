using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface IPronounRepository
{
    Task<List<string>> GetRandomPronounsAsync(Word word, int count, CancellationToken cancellationToken);
}