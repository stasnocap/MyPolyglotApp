using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.ModalVerbs;
using Domain.Vocabulary.ModalVerbs.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class ModalVerbRepository(AppDbContext _dbContext) : IModalVerbRepository
{
    public async Task<IReadOnlyList<string>> GetRandomModalVerbs(Word word, int count, CancellationToken cancellationToken)
    {
        var lowerWordText = word.Text.Value.ToLower();

        var modalVerb = await _dbContext.Set<ModalVerb>()
            .FirstOrDefaultAsync(ca => lowerWordText.Contains((string)ca.Text)
                                       || lowerWordText.Contains((string)ca.FullNegativeForm)
                                       || lowerWordText.Contains((string)ca.ShortNegativeForm), cancellationToken);

        var modalVerbs = await _dbContext
            .Set<ModalVerb>()
            .Where(ca => !lowerWordText.Contains((string)ca.Text)
                         && !lowerWordText.Contains((string)ca.FullNegativeForm)
                         && !lowerWordText.Contains((string)ca.ShortNegativeForm))
            .OrderBy(ca => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (modalVerb is not null)
        {
            if (lowerWordText.Contains((string)modalVerb.Text))
            {
                return modalVerbs.Select(ca => ca.Text.Value).ToList();
            }

            if (lowerWordText.Contains((string)modalVerb.FullNegativeForm))
            {
                return modalVerbs.Select(ca => ca.FullNegativeForm.Value).ToList();
            }

            if (lowerWordText.Contains((string)modalVerb.ShortNegativeForm))
            {
                return modalVerbs.Select(ca => ca.ShortNegativeForm.Value).ToList();
            }
        }
        else
        {
            if (FullNegativeForm.Is(word.Text))
            {
                return modalVerbs.Select(ca => ca.FullNegativeForm.Value).ToList();
            }

            if (ShortNegativeForm.Is(word.Text))
            {
                return modalVerbs.Select(ca => ca.ShortNegativeForm.Value).ToList();
            }

            return modalVerbs.Select(ca => ca.Text.Value).ToList();
        }

        throw new ArgumentOutOfRangeException();
    }
}