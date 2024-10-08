using Domain.Common;
using Domain.Common.Models;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Verbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.Verbs.ValueObjects;

public sealed class PresentParticipleForm : ValueObject
{
    public string Value { get; }

    public static explicit operator string(PresentParticipleForm presentParticipleForm) => presentParticipleForm.Value;

    private PresentParticipleForm(string value)
    {
        Value = value;
    }

    public static bool Is(Text text)
    {
        return text.Value.EndsWith("ing");
    }

    public static ErrorOr<PresentParticipleForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return VerbErrors.EmptyPresentParticipleForm;
        }

        return new PresentParticipleForm(value);
    }

    public static ErrorOr<PresentParticipleForm> From(string verbText, StressOnFinalSyllable stress)
    {
        if (string.IsNullOrWhiteSpace(verbText))
        {
            return VerbErrors.EmptyVerbText;
        }

        var value = GeneratePresentParticipleForm(verbText, stress);

        return new PresentParticipleForm(value);
    }

    private static string GeneratePresentParticipleForm(string text, StressOnFinalSyllable stress)
    {
        var lastTwoChars = text[^2..];

        if (stress.Value && Letters.Vowels.Contains(lastTwoChars[0]) && Letters.Consonants.Contains(lastTwoChars[1]))
        {
            return text + lastTwoChars[1] + "ing";
        }

        if (text.EndsWith("ie"))
        {
            return text[..^2] + 'y' + "ing";
        }

        if (text.EndsWith('e'))
        {
            return text[..^1] + "ing";
        }

        return text + "ing";
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}