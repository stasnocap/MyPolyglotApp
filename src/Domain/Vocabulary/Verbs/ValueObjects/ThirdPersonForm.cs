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

    public static ErrorOr<ThirdPersonForm> From(string verbText)
    {
        if (string.IsNullOrWhiteSpace(verbText))
        {
            return VerbErrors.EmptyVerbText;
        }

        var value = GenerateThirdPersonForm(verbText);

        return new ThirdPersonForm(value);
    }

    private static string GenerateThirdPersonForm(string text)
    {
        if (text == "go")
        {
            return "goes";
        }

        var lastTwoChars = text[^2..];

        if (EsEndings.Any(text.EndsWith))
        {
            return text + "es";
        }

        if (Letters.Consonants.Contains(lastTwoChars[0]) && lastTwoChars[1] == 'y')
        {
            return text[..^1] + "ies";
        }

        return text + 's';
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}