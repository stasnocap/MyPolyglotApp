using Domain.Common;
using Domain.Common.Models;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.ComparisonAdjectives.Errors;
using ErrorOr;

namespace Domain.Vocabulary.ComparisonAdjectives.ValueObjects;

public sealed class SuperlativeForm : ValueObject
{
    public string Value { get; }

    public static explicit operator string(SuperlativeForm superlativeForm) => superlativeForm.Value;

    private SuperlativeForm(string value)
    {
        Value = value;
    }

    public static bool Is(Text text)
    {
        return text.GetWord().EndsWith("est");
    }

    public static SuperlativeForm Create(Text text)
    {
        return new SuperlativeForm(text.Value);
    }

    public static ErrorOr<SuperlativeForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return ComparisonAdjectiveErrors.EmptySuperlativeForm;
        }

        return new SuperlativeForm(value);
    }

    public static ErrorOr<SuperlativeForm> From(string comparisonAdjectiveText, SyllablesCount count)
    {
        if (string.IsNullOrWhiteSpace(comparisonAdjectiveText))
        {
            return ComparisonAdjectiveErrors.EmptyComparisionAdjectiveText;
        }

        var value = GenerateSuperlativeForm(comparisonAdjectiveText, count);

        return new SuperlativeForm(value);
    }

    private static string GenerateSuperlativeForm(string text, SyllablesCount count)
    {
        return count.Value switch
        {
            1 when text.EndsWith('e') => text + "st",
            1 when text[^1] != 'w' && Letters.Consonants.Contains(text[^1]) && Letters.Vowels.Contains(text[^2]) && !Letters.Vowels.Contains(text[^3]) => text + text[^1] + "est",
            1 => text + "est",
            2 when text == "polite" => "politest",
            2 when text.EndsWith('y') => text[..^1] + "iest",
            2 when text.EndsWith("le") => text + "st",
            2 when text.EndsWith("er") || text.EndsWith("ow") => text + "est",
            2 => "most " + text,
            _ => "most " + text
        };
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}