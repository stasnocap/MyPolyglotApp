using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.Adverbs;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class AdverbRepository(AppDbContext _dbContext) : IAdverbRepository
{
    public async Task<IReadOnlyList<string>> GetRandomAdverbs(Word word, int count, CancellationToken cancellationToken)
    {
        var adverb = await _dbContext
            .Set<Adverb>()
            .AsNoTracking()
            .FirstOrDefaultAsync(cancellationToken);

        var query = _dbContext
            .Set<Adverb>()
            .AsNoTracking()
            .OrderBy(a => Guid.NewGuid())
            .Take(count);

        if (adverb is not null)
        {
            query = query.Where(a => a.Type == adverb.Type && a.Id != adverb.Id);
        }

        var adverbs = await query.ToListAsync(cancellationToken);

        return adverbs.Select(x => x.Text.Value).ToList();
    }
}