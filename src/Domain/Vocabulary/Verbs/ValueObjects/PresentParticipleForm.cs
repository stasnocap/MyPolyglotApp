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

    public static ErrorOr<PresentParticipleForm> From(Text verbText, bool stressOnFinalSyllable)
    {
        if (string.IsNullOrWhiteSpace(verbText.Value))
        {
            return VerbErrors.EmptyVerbText;
        }

        var value = GeneratePresentParticipleForm(verbText, stressOnFinalSyllable);

        return new PresentParticipleForm(value);
    }

    private static string GeneratePresentParticipleForm(Text text, bool stressOnFinalSyllable)
    {
        var textValue = text.Value;
        
        var lastTwoChars = textValue[^2..];

        if (stressOnFinalSyllable && Letters.Vowels.Contains(lastTwoChars[0]) && Letters.Consonants.Contains(lastTwoChars[1]))
        {
            return textValue + lastTwoChars[1] + "ing";
        }

        if (textValue.EndsWith("ie"))
        {
            return textValue[..^2] + 'y' + "ing";
        }

        if (textValue.EndsWith('e'))
        {
            return textValue[..^1] + "ing";
        }

        return text + "ing";
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}