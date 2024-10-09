using Domain.Common;
using Domain.Common.Models;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.ComparisonAdjectives.Errors;
using ErrorOr;

namespace Domain.Vocabulary.ComparisonAdjectives.ValueObjects;

public sealed class ComparativeForm : ValueObject
{
    public string Value { get; }

    public static explicit operator string(ComparativeForm comparativeForm) => comparativeForm.Value;

    private ComparativeForm(string value)
    {
        Value = value;
    }

    public static bool Is(Text text)
    {
        return text.Value.StartsWith("more") || text.Value.EndsWith("er");
    }

    public static ComparativeForm Create(Text text)
    {
        return new ComparativeForm(text.Value);
    }

    public static ErrorOr<ComparativeForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return ComparisonAdjectiveErrors.EmptyComparativeForm;
        }

        return new ComparativeForm(value);
    }

    public static ErrorOr<ComparativeForm> From(Text comparisonAdjectiveText, SyllablesCount count)
    {
        if (string.IsNullOrWhiteSpace(comparisonAdjectiveText.Value))
        {
            return ComparisonAdjectiveErrors.EmptyComparisionAdjectiveText;
        }

        var value = GenerateComparativeForm(comparisonAdjectiveText, count);

        return new ComparativeForm(value);
    }

    private static string GenerateComparativeForm(Text text, SyllablesCount count)
    {
        var textValue = text.Value;
        return count.Value switch
        {
            1 when textValue.EndsWith('e') => textValue + 'r',
            1 when textValue[^1] != 'w' && Letters.Consonants.Contains(textValue[^1]) && Letters.Vowels.Contains(textValue[^2]) && !Letters.Vowels.Contains(textValue[^3]) => textValue + textValue[^1] + "er",
            1 => textValue + "er",
            2 when textValue == "polite" => "politer",
            2 when textValue.EndsWith('y') => textValue[..^1] + "ier",
            2 when textValue.EndsWith("le") => textValue + "r",
            2 when textValue.EndsWith("er") || textValue.EndsWith("ow") => textValue + "er",
            2 => "more " + textValue,
            _ => "more " + textValue
        };
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}