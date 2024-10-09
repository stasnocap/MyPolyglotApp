using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.ModalVerbs;
using Domain.Vocabulary.ModalVerbs.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class ModalVerbRepository(AppDbContext _dbContext) : IModalVerbRepository
{
    public async Task<IReadOnlyList<string>> GetRandomModalVerbsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var lowerWordText = word.Text.Value.ToLower();

        var modalVerb = await _dbContext.Set<ModalVerb>()
            .FirstOrDefaultAsync(mv => lowerWordText.Contains((string)mv.Text)
                                       || lowerWordText.Contains((string)mv.FullNegativeForm)
                                       || lowerWordText.Contains((string)mv.ShortNegativeForm), cancellationToken);

        var modalVerbs = await _dbContext
            .Set<ModalVerb>()
            .Where(mv => !lowerWordText.Contains((string)mv.Text)
                         && !lowerWordText.Contains((string)mv.FullNegativeForm)
                         && !lowerWordText.Contains((string)mv.ShortNegativeForm))
            .OrderBy(mv => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (modalVerb is not null)
        {
            if (lowerWordText.Contains((string)modalVerb.Text))
            {
                return modalVerbs.Select(mv => mv.Text.Value).ToList();
            }

            if (lowerWordText.Contains((string)modalVerb.FullNegativeForm))
            {
                return modalVerbs.Select(mv => mv.FullNegativeForm.Value).ToList();
            }

            if (lowerWordText.Contains((string)modalVerb.ShortNegativeForm))
            {
                return modalVerbs.Select(mv => mv.ShortNegativeForm.Value).ToList();
            }
        }
        else
        {
            if (FullNegativeForm.Is(word.Text))
            {
                return modalVerbs.Select(mv => mv.FullNegativeForm.Value).ToList();
            }

            if (ShortNegativeForm.Is(word.Text))
            {
                return modalVerbs.Select(mv => mv.ShortNegativeForm.Value).ToList();
            }

            return modalVerbs.Select(mv => mv.Text.Value).ToList();
        }

        throw new ArgumentOutOfRangeException();
    }
}