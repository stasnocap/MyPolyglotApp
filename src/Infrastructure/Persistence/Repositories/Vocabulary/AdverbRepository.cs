using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.Adverbs;
using Domain.Vocabulary.Adverbs.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class AdverbRepository(AppDbContext _dbContext) : IAdverbRepository
{
    public async Task<IReadOnlyList<string>> GetRandomAdverbsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var adverb = await _dbContext
            .Set<Adverb>()
            .AsNoTracking()
            .Where(a => word.Text.Value.ToLower().Contains((string)a.Text))
            .FirstOrDefaultAsync(cancellationToken);

        var query = _dbContext
            .Set<Adverb>()
            .AsNoTracking();
        
        if (adverb is not null)
        {
            query = query.Where(a => a.Type == adverb.Type && a.Id != adverb.Id);
        }

        var adverbs = await query
            .OrderBy(a => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        return adverbs.Select(x => x.Text.Value).ToList();
    }
}