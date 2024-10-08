using Domain.Common;
using Domain.Common.Models;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Verbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.Verbs.ValueObjects;

public sealed class ThirdPersonForm : ValueObject
{
    private static readonly IReadOnlyList<string> EsEndings = ["ch", "s", "sh", "x", "z"];

    public string Value { get; }

    public static explicit operator string(ThirdPersonForm thirdPersonForm) => thirdPersonForm.Value;

    public static bool Is(Text text)
    {
        return text.Value.EndsWith("s");
    }

    private ThirdPersonForm(string value)
    {
        Value = value;
    }

    public static ErrorOr<ThirdPersonForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return VerbErrors.EmptyThirdPersonForm;
        }

        return new ThirdPersonForm(value);
    }

    public static ErrorOr<ThirdPersonForm> From(Text verbText)
    {
        if (string.IsNullOrWhiteSpace(verbText.Value))
        {
            return VerbErrors.EmptyVerbText;
        }

        var value = GenerateThirdPersonForm(verbText);

        return new ThirdPersonForm(value);
    }

    private static string GenerateThirdPersonForm(Text text)
    {
        var textValue = text.Value;
        
        if (textValue == "go")
        {
            return "goes";
        }

        var lastTwoChars = textValue[^2..];

        if (EsEndings.Any(textValue.EndsWith))
        {
            return textValue + "es";
        }

        if (Letters.Consonants.Contains(lastTwoChars[0]) && lastTwoChars[1] == 'y')
        {
            return textValue[..^1] + "ies";
        }

        return textValue + 's';
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}