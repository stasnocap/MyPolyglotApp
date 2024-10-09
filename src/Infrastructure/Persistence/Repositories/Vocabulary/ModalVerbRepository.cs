using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.ModalVerbs;
using Domain.Vocabulary.ModalVerbs.ValueObjects;
using Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class ModalVerbRepository(AppDbContext _dbContext) : IModalVerbRepository
{
    public async Task<IReadOnlyList<string>> GetRandomModalVerbsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var wordText = word.Text.GetWord();

        var modalVerb = await _dbContext.Set<ModalVerb>()
            .FirstOrDefaultAsync(mv => wordText == mv.Text
                                       || (string)wordText == (string)mv.FullNegativeForm
                                       || (string)wordText == (string)mv.ShortNegativeForm, cancellationToken);

        var modalVerbs = await _dbContext
            .Set<ModalVerb>()
            .WhereIf(modalVerb is not null, mv => mv.Id != modalVerb!.Id)
            .OrderBy(mv => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (modalVerb is not null)
        {
            if (wordText == modalVerb.Text)
            {
                return modalVerbs.Select(mv => mv.Text.Value).ToList();
            }

            if ((string)wordText == (string)modalVerb.FullNegativeForm)
            {
                return modalVerbs.Select(mv => mv.FullNegativeForm.Value).ToList();
            }

            if ((string)wordText == (string)modalVerb.ShortNegativeForm)
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