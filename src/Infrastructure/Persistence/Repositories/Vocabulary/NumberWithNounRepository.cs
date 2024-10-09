using System.Text.RegularExpressions;
using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises.Entities;

namespace Infrastructure.Persistence.Repositories.Vocabulary;

public class NumberWithNounRepository(INounRepository _nounRepository) : INumberWithNounRepository
{
    public async Task<IReadOnlyList<string>> GetRandomNumberWithNounsAsync(Word word, int count, CancellationToken cancellationToken)
    {
        var nouns = await _nounRepository.GetRandomNounsAsync(word, count, cancellationToken);
        
        var number = Regex.Match(word.Text.Value, @"\d+").Value;

        return nouns.Select(n => $"{number} {n}").ToList();
    }
}