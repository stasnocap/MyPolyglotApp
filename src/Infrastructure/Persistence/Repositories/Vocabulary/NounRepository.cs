using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;
using Domain.Vocabulary.Nouns;
using Domain.Vocabulary.Nouns.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class NounRepository(AppDbContext _dbContext) : INounRepository
{
    public async Task<IReadOnlyList<string>> GetRandomNounsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var lowerWordText = word.Text.Value.ToLower();

        var noun = await _dbContext.Set<Noun>()
            .FirstOrDefaultAsync(n => lowerWordText.Contains((string)n.Text)
                                       || lowerWordText.Contains((string)n.PluralForm)
                                       , cancellationToken);

        var nouns = await _dbContext
            .Set<Noun>()
            .Where(n => !lowerWordText.Contains((string)n.Text)
                         && !lowerWordText.Contains((string)n.PluralForm))
            .OrderBy(n => Guid.NewGuid())
            .Take(count)
            .ToListAsync(cancellationToken);

        if (noun is not null)
        {
            if (lowerWordText.Contains((string)noun.Text))
            {
                return nouns.Select(n => n.Text.Value).ToList();
            }

            if (lowerWordText.Contains((string)noun.PluralForm))
            {
                return nouns.Select(n => n.PluralForm.Value).ToList();
            }
        }
        else
        {
            if (PluralForm.Is(word.Text))
            {
                return nouns.Select(n => n.PluralForm.Value).ToList();
            }

            return nouns.Select(n => n.Text.Value).ToList();
        }

        throw new ArgumentOutOfRangeException();
    }
}