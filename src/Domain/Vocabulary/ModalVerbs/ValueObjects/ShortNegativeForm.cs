using Domain.Common.Models;
using Domain.Vocabulary.ModalVerbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.ModalVerbs.ValueObjects;

public class ShortNegativeForm : ValueObject
{
    public string Value { get; }

    private ShortNegativeForm(string value)
    {
        Value = value;
    }

    public static ErrorOr<ShortNegativeForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return ModalVerbErrors.EmptyShortNegativeForm;
        }

        return new ShortNegativeForm(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}