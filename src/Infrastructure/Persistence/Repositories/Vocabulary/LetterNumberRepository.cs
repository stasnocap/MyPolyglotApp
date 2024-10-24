using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.LetterNumbers;
using Infrastructure.Persistence.Extensions;
using Infrastructure.Persistence.Extensions.Queryable;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class LetterNumberRepository(AppDbContext _dbContext) : ILetterNumberRepository
{
    public async Task<List<string>> GetRandomLetterNumbersAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var wordText = word.Text.GetWord();

        var letterNumber = await _dbContext
            .Set<LetterNumber>()
            .AsNoTracking()
            .Where(ln => wordText == ln.Text)
            .FirstOrDefaultAsync(cancellationToken);

        var halfOfACount = Math.Ceiling(count / 2.0);

        var letterNumbers = await _dbContext
            .Set<LetterNumber>()
            .AsNoTracking()
            .OrderBy(ln => Guid.NewGuid())
            .WhereIf(letterNumber is not null, ln => ln.Id != letterNumber!.Id
                                                     && letterNumber.Number.Value - halfOfACount <= (int)ln.Number && (int)ln.Number <= letterNumber.Number.Value + halfOfACount)
            .Take(count)
            .ToListAsync(cancellationToken);

        if (letterNumbers.Count < count)
        {
            var retrievedLetterNumberIds = letterNumbers.Select(ln => ln.Id).ToList();

            letterNumbers.AddRange(await _dbContext
                .Set<LetterNumber>()
                .AsNoTracking()
                .OrderBy(ln => Guid.NewGuid())
                .Where(ln => !retrievedLetterNumberIds.Contains(ln.Id))
                .Take(count - letterNumbers.Count)
                .ToListAsync(cancellationToken));
        }

        return letterNumbers.Select(ln => ln.Text.Value).ToList();
    }
}