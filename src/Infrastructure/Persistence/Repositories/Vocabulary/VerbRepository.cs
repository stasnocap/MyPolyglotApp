using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.Verbs;
using Domain.Vocabulary.Verbs.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class VerbRepository(AppDbContext _dbContext) : IVerbRepository
{
    public async Task<IReadOnlyList<string>> GetRandomVerbsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var lowerWordText = word.Text.Value.ToLower();

        var verb = await _dbContext.Set<Verb>()
            .FirstOrDefaultAsync(v => lowerWordText.Contains((string)v.Text)
                                       || lowerWordText.Contains((string)v.PastForm)
                                       || lowerWordText.Contains((string)v.PastParticipleForm)
                                       || lowerWordText.Contains((string)v.PresentParticipleForm)
                                       || lowerWordText.Contains((string)v.ThirdPersonForm)
                , cancellationToken);

        var verbs = await _dbContext
            .Set<Verb>()
            .Where(v => !lowerWordText.Contains((string)v.Text)
                         && !lowerWordText.Contains((string)v.PastForm)
                         && !lowerWordText.Contains((string)v.PastParticipleForm)
                         && !lowerWordText.Contains((string)v.PresentParticipleForm)
                         && !lowerWordText.Contains((string)v.ThirdPersonForm)
            )
            .OrderBy(v => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (verb is not null)
        {
            if (lowerWordText.Contains((string)verb.Text))
            {
                return verbs.Select(v => v.Text.Value).ToList();
            }

            if (lowerWordText.Contains((string)verb.PastForm))
            {
                return verbs.Select(v => v.PastForm.Value).ToList();
            }

            if (lowerWordText.Contains((string)verb.PastParticipleForm))
            {
                return verbs.Select(v => v.PastParticipleForm.Value).ToList();
            }

            if (lowerWordText.Contains((string)verb.PresentParticipleForm))
            {
                return verbs.Select(v => v.PresentParticipleForm.Value).ToList();
            }

            if (lowerWordText.Contains((string)verb.ThirdPersonForm))
            {
                return verbs.Select(v => v.ThirdPersonForm.Value).ToList();
            }
        }
        else
        {
            if (PastForm.Is(word.Text))
            {
                return verbs.Select(v => v.PastForm.Value).ToList();
            }

            if (PastParticipleForm.Is(word.Text))
            {
                return verbs.Select(v => v.PastParticipleForm.Value).ToList();
            }

            if (PresentParticipleForm.Is(word.Text))
            {
                return verbs.Select(v => v.PresentParticipleForm.Value).ToList();
            }

            if (ThirdPersonForm.Is(word.Text))
            {
                return verbs.Select(v => v.ThirdPersonForm.Value).ToList();
            }

            return verbs.Select(v => v.Text.Value).ToList();
        }

        throw new ArgumentOutOfRangeException();
    }
}