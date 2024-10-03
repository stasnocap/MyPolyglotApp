using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.LetterNumbers;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class LetterNumberRepository(AppDbContext _dbContext) : ILetterNumberRepository
{
    public async Task<IReadOnlyList<string>> GetRandomLetterNumbers(Word word, int count, CancellationToken cancellationToken)
    {
        var letterNumber = await _dbContext
            .Set<LetterNumber>()
            .AsNoTracking()
            .Where(ln => word.Text.Value.ToLower().Contains((string)ln.Text))
            .FirstOrDefaultAsync(cancellationToken);

        var letterNumbers = letterNumber is null
            ? await _dbContext
                .Set<LetterNumber>()
                .OrderByDescending(ln => ln.Number)
                .AsNoTracking()
                .Where(ln => word.Text.Value.ToLower().Contains((string)ln.Text))
                .Take(count)
                .ToListAsync(cancellationToken)
            : await _dbContext
                .Set<LetterNumber>()
                .AsNoTracking()
                .OrderBy(ln => Guid.NewGuid())
                .Where(ln => letterNumber.Number.Value >= (int)ln.Number && (int)ln.Number <= letterNumber.Number.Value + 10)
                .Take(count)
                .ToListAsync(cancellationToken);

        return letterNumbers.Select(ln => ln.Text.Value).ToList();
    }
}