using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.PrimaryVerbs;
using Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class PrimaryVerbRepository(AppDbContext _dbContext) : IPrimaryVerbRepository
{
    public async Task<IReadOnlyList<string>> GetRandomPrimaryVerbsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var lowerWordText = word.Text.Value.ToLower();

        var primaryVerb = await _dbContext.Set<PrimaryVerb>()
            .FirstOrDefaultAsync(pv => lowerWordText.Contains((string)pv.Text)
                                       || lowerWordText.Contains((string)pv.PastForm)
                                       || lowerWordText.Contains((string)pv.PastParticipleForm)
                                       || lowerWordText.Contains((string)pv.PresentParticipleForm)
                                       || lowerWordText.Contains((string)pv.ThirdPersonForm)
                                       || pv.FullNegativeForms.Any(fnf => lowerWordText.Contains((string)fnf))
                                       || pv.ShortNegativeForms.Any(snf => lowerWordText.Contains((string)snf))
                                       || pv.AdditionalForms.Any(af => lowerWordText.Contains((string)af)
                                       ), cancellationToken);

        var primaryVerbs = await _dbContext
            .Set<PrimaryVerb>()
            .AsNoTracking()
            .WhereIf(primaryVerb is not null, pv => pv.Id != primaryVerb!.Id)
            .OrderBy(pv => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (primaryVerb is not null)
        {
            if (lowerWordText.Contains((string)primaryVerb.Text))
            {
                return primaryVerbs.Select(pv => pv.Text.Value).ToList();
            }

            if (lowerWordText.Contains((string)primaryVerb.PastForm))
            {
                return primaryVerbs.Select(pv => pv.PastForm.Value).ToList();
            }

            if (lowerWordText.Contains((string)primaryVerb.PastParticipleForm))
            {
                return primaryVerbs.Select(pv => pv.PastParticipleForm.Value).ToList();
            }

            if (lowerWordText.Contains((string)primaryVerb.PresentParticipleForm))
            {
                return primaryVerbs.Select(pv => pv.PastParticipleForm.Value).ToList();
            }

            if (lowerWordText.Contains((string)primaryVerb.ThirdPersonForm))
            {
                return primaryVerbs.Select(pv => pv.ThirdPersonForm.Value).ToList();
            }

            if (primaryVerb.FullNegativeForms.Any(fnf => lowerWordText.Contains((string)fnf)))
            {
                return primaryVerb.FullNegativeForms.Select(fnf => fnf.Value).ToList();
            }

            if (primaryVerb.ShortNegativeForms.Any(snf => lowerWordText.Contains((string)snf)))
            {
                return primaryVerb.ShortNegativeForms.Select(snf => snf.Value).ToList();
            }

            if (primaryVerb.AdditionalForms.Any(af => lowerWordText.Contains((string)af)))
            {
                return primaryVerb.AdditionalForms.Select(af => af.Value).ToList();
            }
        }

        return primaryVerbs.Select(pv => pv.Text.Value).ToList();
    }
}