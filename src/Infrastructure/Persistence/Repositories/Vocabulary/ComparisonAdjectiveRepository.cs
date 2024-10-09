using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.ComparisonAdjectives;
using Domain.Vocabulary.ComparisonAdjectives.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class ComparisonAdjectiveRepository(AppDbContext _dbContext) : IComparisionAdjectiveRepository
{
    public async Task<IReadOnlyList<string>> GetRandomComparisonAdjectivesAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var lowerWordText = word.Text.Value.ToLower();

        var comparisonAdjective = await _dbContext.Set<ComparisonAdjective>()
            .FirstOrDefaultAsync(ca => lowerWordText.Contains((string)ca.Text)
                                       || lowerWordText.Contains((string)ca.ComparativeForm)
                                       || lowerWordText.Contains((string)ca.SuperlativeForm), cancellationToken);

        var comparisonAdjectives = await _dbContext
            .Set<ComparisonAdjective>()
            .Where(ca => !lowerWordText.Contains((string)ca.Text)
                         && !lowerWordText.Contains((string)ca.ComparativeForm)
                         && !lowerWordText.Contains((string)ca.SuperlativeForm))
            .OrderBy(ca => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (comparisonAdjective is not null)
        {
            if (lowerWordText.Contains((string)comparisonAdjective.Text))
            {
                return comparisonAdjectives.Select(ca => ca.Text.Value).ToList();
            }

            if (lowerWordText.Contains((string)comparisonAdjective.ComparativeForm))
            {
                return comparisonAdjectives.Select(ca => ca.ComparativeForm.Value).ToList();
            }

            if (lowerWordText.Contains((string)comparisonAdjective.SuperlativeForm))
            {
                return comparisonAdjectives.Select(ca => ca.SuperlativeForm.Value).ToList();
            }
        }
        else
        {
            if (ComparativeForm.Is(word.Text))
            {
                return comparisonAdjectives.Select(ca => ca.ComparativeForm.Value).ToList();
            }

            if (SuperlativeForm.Is(word.Text))
            {
                return comparisonAdjectives.Select(ca => ca.SuperlativeForm.Value).ToList();
            }

            return comparisonAdjectives.Select(ca => ca.Text.Value).ToList();
        }

        throw new ArgumentOutOfRangeException();
    }
}