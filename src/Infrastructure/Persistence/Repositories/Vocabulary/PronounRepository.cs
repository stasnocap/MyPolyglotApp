using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.Pronouns;
using Infrastructure.Persistence.Extensions;
using Infrastructure.Persistence.Extensions.Queryable;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class PronounRepository(AppDbContext _dbContext) : IPronounRepository
{
    public async Task<List<string>> GetRandomPronounsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var pronoun = await _dbContext
            .Set<Pronoun>()
            .AsNoTracking()
            .FirstOrDefaultAsync(a => word.Text.GetWord() == a.Text, cancellationToken);

        var pronouns = await _dbContext
            .Set<Pronoun>()
            .AsNoTracking()
            .WhereIf(pronoun is not null, a => a.Type == pronoun!.Type && a.Id != pronoun.Id)
            .OrderBy(a => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (pronouns.Count < count)
        {
            var retrievedPronounIds = pronouns.Select(p => p.Id).ToList();
            
            pronouns.AddRange(await _dbContext
                .Set<Pronoun>()
                .AsNoTracking()
                .Where(p => !retrievedPronounIds.Contains(p.Id))
                .WhereIf(pronoun is not null, a => a.Id != pronoun!.Id)
                .OrderByDescending(p => Guid.NewGuid())
                .Take(count - pronouns.Count)
                .ToListAsync(cancellationToken));
        }

        return pronouns.Select(x => x.Text.Value).ToList();
    }
}