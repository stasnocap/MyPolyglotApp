using Domain.Common;
using Domain.Common.Models;
using Domain.Vocabulary.ComparisonAdjectives.Errors;
using ErrorOr;

namespace Domain.Vocabulary.ComparisonAdjectives.ValueObjects;

public sealed class ComparativeForm : ValueObject
{
    public string Value { get; }

    private ComparativeForm(string value)
    {
        Value = value;
    }

    public static ErrorOr<ComparativeForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return ComparisonAdjectiveErrors.EmptyComparativeForm;
        }

        return new ComparativeForm(value);
    }

    public static ErrorOr<ComparativeForm> From(string comparisonAdjectiveText, SyllablesCount count)
    {
        if (string.IsNullOrWhiteSpace(comparisonAdjectiveText))
        {
            return ComparisonAdjectiveErrors.EmptyComparisionAdjectiveText;
        }

        var value = GenerateComparativeForm(comparisonAdjectiveText, count);

        return new ComparativeForm(value);
    }
    
    private static string GenerateComparativeForm(string text, SyllablesCount count)
    {
        return count.Value switch
        {
            1 when text.EndsWith('e') => text + 'r',
            1 when text[^1] != 'w' && Letters.Consonants.Contains(text[^1]) && Letters.Vowels.Contains(text[^2]) && !Letters.Vowels.Contains(text[^3]) => text + text[^1] + "er",
            1 => text + "er",
            2 when text == "polite" => "politer",
            2 when text.EndsWith('y') => text[..^1] + "ier",
            2 when text.EndsWith("le") => text + "r",
            2 when text.EndsWith("er") || text.EndsWith("ow") => text + "er",
            2 => "more " + text,
            _ => "more " + text
        };
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    } 
}