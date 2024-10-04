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
        return singularNoun.GetWord().EndsWith("s");
    }

    public static ErrorOr<PluralForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return NounErrors.EmptyPluralFormForm;
        }

        return new PluralForm(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}