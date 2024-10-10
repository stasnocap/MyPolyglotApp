using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.ComparisonAdjectives;
using Domain.Vocabulary.ComparisonAdjectives.ValueObjects;
using Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class ComparisonAdjectiveRepository(AppDbContext _dbContext) : IComparisonAdjectiveRepository
{
    public async Task<List<string>> GetRandomComparisonAdjectivesAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var wordText = word.Text.GetWord();

        var comparisonAdjective = await _dbContext.Set<ComparisonAdjective>()
            .FirstOrDefaultAsync(ca => wordText == ca.Text
                                       || (string)wordText == (string)ca.ComparativeForm
                                       || (string)wordText == (string)ca.SuperlativeForm, cancellationToken);

        var comparisonAdjectives = await _dbContext
            .Set<ComparisonAdjective>()
            .WhereIf(comparisonAdjective is not null, ca => ca.Id != comparisonAdjective!.Id)
            .OrderBy(ca => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (comparisonAdjective is not null)
        {
            if (wordText == comparisonAdjective.Text)
            {
                return comparisonAdjectives.Select(ca => ca.Text.Value).ToList();
            }

            if (wordText.Value == comparisonAdjective.ComparativeForm.Value)
            {
                return comparisonAdjectives.Select(ca => ca.ComparativeForm.Value).ToList();
            }

            if (wordText.Value == comparisonAdjective.SuperlativeForm.Value)
            {
                return comparisonAdjectives.Select(ca => ca.SuperlativeForm.Value).ToList();
            }
        }
        else
        {
            if (ComparativeForm.Is(wordText))
            {
                return comparisonAdjectives.Select(ca => ca.ComparativeForm.Value).ToList();
            }

            if (SuperlativeForm.Is(wordText))
            {
                return comparisonAdjectives.Select(ca => ca.SuperlativeForm.Value).ToList();
            }

            return comparisonAdjectives.Select(ca => ca.Text.Value).ToList();
        }

        throw new ArgumentOutOfRangeException();
    }
}