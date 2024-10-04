using Domain.Common;
using Domain.Common.Models;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Verbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.Verbs.ValueObjects;

public sealed class PastForm : ValueObject
{
    public string Value { get; }

    public static explicit operator string(PastForm pastForm) => pastForm.Value;

    public static bool Is(Text text)
    {
        return text.Value.EndsWith("ed");
    }

    private PastForm(string value)
    {
        Value = value;
    }

    public static ErrorOr<PastForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return VerbErrors.EmptyPastForm;
        }

        return new PastForm(value);
    }

    public static ErrorOr<PastForm> From(string verbText, StressOnFinalSyllable stress)
    {
        if (string.IsNullOrWhiteSpace(verbText))
        {
            return VerbErrors.EmptyVerbText;
        }

        var value = GeneratePastForm(verbText, stress);

        return new PastForm(value);
    }
    
    private static string GeneratePastForm(string text, StressOnFinalSyllable stress)
    {
        switch (text)
        {
            case "ship":
                return "shipped";
            case "chew":
                return "chewed";
            case "relax":
                return "relaxed";
        }

        var lastTwoChars = text[^2..];

        if (stress.Value && Letters.Vowels.Contains(lastTwoChars[0]) && Letters.Consonants.Contains(lastTwoChars[1]))
        {
            return text + lastTwoChars[1] + "ed";
        }

        if (Letters.Vowels.Contains(lastTwoChars[0]) && text.EndsWith('y'))
        {
            return text + "ed";
        }

        if (text.EndsWith('y'))
        {
            return text[..^1] + "ied";
        }

        if (text.EndsWith('e'))
        {
            return text + 'd';
        }

        return text + "ed";
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}