using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.Compounds;
using Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class CompoundRepository(AppDbContext _dbContext) : ICompoundRepository
{
    public async Task<List<string>> GetRandomCompoundsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var compound = await _dbContext
            .Set<Compound>()
            .AsNoTracking()
            .FirstOrDefaultAsync(c => word.Text.GetWord() == c.Text, cancellationToken);

        var compounds = await _dbContext
            .Set<Compound>()
            .AsNoTracking()
            .WhereIf(compound is not null, c => c.Type == compound!.Type && c.Id != compound.Id)
            .OrderBy(a => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (compounds.Count < count)
        {
            var retrievedCompoundIds = compounds.Select(c => c.Id).ToList();
            
            compounds.AddRange(await _dbContext.Set<Compound>()
                .AsNoTracking()
                .Where(c => !retrievedCompoundIds.Contains(c.Id))
                .WhereIf(compound is not null, c => c.Id != compound!.Id)
                .OrderBy(a => Guid.NewGuid())
                .Take(count - compounds.Count)
                .ToListAsync(cancellationToken));
        }

        return compounds.Select(x => x.Text.Value).ToList();
    }
}