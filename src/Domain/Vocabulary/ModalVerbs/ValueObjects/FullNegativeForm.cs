using Domain.Common.Models;
using Domain.Vocabulary.ModalVerbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.ModalVerbs.ValueObjects;

public class FullNegativeForm : ValueObject
{
    public string Value { get; }

    private FullNegativeForm(string value)
    {
        Value = value;
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