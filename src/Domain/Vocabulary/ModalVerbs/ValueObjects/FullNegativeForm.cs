using Domain.Common.Models;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.ModalVerbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.ModalVerbs.ValueObjects;

public class FullNegativeForm : ValueObject
{
    public string Value { get; }

    public static explicit operator string(FullNegativeForm fullNegativeForm) => fullNegativeForm.Value;

    private FullNegativeForm(string value)
    {
        Value = value;
    }

    public static bool Is(Text text)
    {
        return text.Value.EndsWith("not");
    }

    public static ErrorOr<FullNegativeForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return ModalVerbErrors.EmptyFullNegativeForm;
        }

        return new FullNegativeForm(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}