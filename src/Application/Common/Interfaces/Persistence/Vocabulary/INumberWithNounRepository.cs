using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface INumberWithNounRepository
{
    Task<List<string>> GetRandomNumberWithNounsAsync(Word word, int count, CancellationToken cancellationToken);
}