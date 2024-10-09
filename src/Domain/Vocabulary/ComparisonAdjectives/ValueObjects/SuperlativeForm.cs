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
        return text.Value.StartsWith("most") || text.Value.EndsWith("est");
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

    public static ErrorOr<SuperlativeForm> From(Text comparisonAdjectiveText, SyllablesCount count)
    {
        if (string.IsNullOrWhiteSpace(comparisonAdjectiveText.Value))
        {
            return ComparisonAdjectiveErrors.EmptyComparisionAdjectiveText;
        }

        var value = GenerateSuperlativeForm(comparisonAdjectiveText, count);

        return new SuperlativeForm(value);
    }

    private static string GenerateSuperlativeForm(Text text, SyllablesCount count)
    {
        var textValue = text.Value;
        return count.Value switch
        {
            1 when textValue.EndsWith('e') => textValue + "st",
            1 when textValue[^1] != 'w' && Letters.Consonants.Contains(textValue[^1]) && Letters.Vowels.Contains(textValue[^2]) && !Letters.Vowels.Contains(textValue[^3]) => textValue + textValue[^1] + "est",
            1 => textValue + "est",
            2 when textValue == "polite" => "politest",
            2 when textValue.EndsWith('y') => textValue[..^1] + "iest",
            2 when textValue.EndsWith("le") => textValue + "st",
            2 when textValue.EndsWith("er") || textValue.EndsWith("ow") => textValue + "est",
            2 => "most " + textValue,
            _ => "most " + textValue
        };
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}