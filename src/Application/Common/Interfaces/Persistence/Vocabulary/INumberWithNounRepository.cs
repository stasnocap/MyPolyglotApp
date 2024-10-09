using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface INumberWithNounRepository
{
    Task<IReadOnlyList<string>> GetRandomNumberWithNounsAsync(Word word, int count, CancellationToken cancellationToken);
}