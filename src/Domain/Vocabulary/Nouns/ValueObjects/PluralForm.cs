using Domain.Common;
using Domain.Common.Models;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Nouns.Errors;
using ErrorOr;

namespace Domain.Vocabulary.Nouns.ValueObjects;

public class PluralForm : ValueObject
{
    public string Value { get; }

    public static explicit operator string(PluralForm pluralForm) => pluralForm.Value;

    private PluralForm(string value)
    {
        Value = value;
    }

    public static bool Is(Text singularNoun)
    {
        return singularNoun.Value.EndsWith("s");
    }

    public static ErrorOr<PluralForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return NounErrors.EmptyPluralFormForm;
        }

        return new PluralForm(value);
    }

    public static PluralForm Create(Text singularNoun)
    {
        var pluralFormStr = GeneratePluralForm(singularNoun.Value);

        return new PluralForm(pluralFormStr);
    }

    private static string GeneratePluralForm(string text)
    {
        if (text.EndsWith("on") && text[text.Length - 3] != 'o')
        {
            return text[..^2] + "a";
        }

        if (text.EndsWith("is"))
        {
            return text[..^2] + "es";
        }

        if (text.EndsWith('f')
            && text != "roof"
            && text != "belief"
            && text != "chef"
            && text != "chief")
        {
            return text[..^1] + "ves";
        }

        if (text.EndsWith("fe"))
        {
            return text[..^2] + "ves";
        }

        if (text.EndsWith('y') && Letters.Consonants.Contains(text[text.Length - 2]))
        {
            return text[..^1] + "ies";
        }

        if (text.EndsWith('s')
            || text.EndsWith("ss")
            || text.EndsWith("sh")
            || text.EndsWith("ch")
            || text.EndsWith("x")
            || text.EndsWith("z")
            || text.EndsWith("es")
            || text.EndsWith("o")
            && text != "photo"
            && text != "piano"
            && text != "halo")
        {
            return text + "es";
        }

        return text + "s";
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}