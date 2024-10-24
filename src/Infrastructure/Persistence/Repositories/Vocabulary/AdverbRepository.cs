using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.Adverbs;
using Domain.Vocabulary.Adverbs.ValueObjects;
using Infrastructure.Persistence.Extensions;
using Infrastructure.Persistence.Extensions.Queryable;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class AdverbRepository(AppDbContext _dbContext) : IAdverbRepository
{
    public async Task<List<string>> GetRandomAdverbsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var adverb = await _dbContext
            .Set<Adverb>()
            .AsNoTracking()
            .FirstOrDefaultAsync(a => word.Text.GetWord() == a.Text, cancellationToken);

        var adverbs = await _dbContext
            .Set<Adverb>()
            .AsNoTracking()
            .WhereIf(adverb is not null, a => a.Type == adverb!.Type && a.Id != adverb.Id)
            .OrderBy(a => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        return adverbs.Select(x => x.Text.Value).ToList();
    }
}