using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.Compounds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class CompoundRepository(AppDbContext _dbContext) : ICompoundRepository
{
    public async Task<IReadOnlyList<string>> GetRandomCompoundsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var compound = await _dbContext
            .Set<Compound>()
            .AsNoTracking()
            .FirstOrDefaultAsync(cancellationToken);

        var query = _dbContext
            .Set<Compound>()
            .AsNoTracking()
            .OrderBy(a => Guid.NewGuid())
            .Take(count);

        if (compound is not null)
        {
            query = query.Where(a => a.Type == compound.Type && a.Id != compound.Id);
        }

        var compounds = await query.ToListAsync(cancellationToken);

        return compounds.Select(x => x.Text.Value).ToList();
    }
}