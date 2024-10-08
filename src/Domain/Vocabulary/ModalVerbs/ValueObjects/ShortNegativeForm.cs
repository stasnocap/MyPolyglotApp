using Domain.Common.Models;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.ModalVerbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.ModalVerbs.ValueObjects;

public class ShortNegativeForm : ValueObject
{
    public string Value { get; }

    public static explicit operator string(ShortNegativeForm shortNegativeForm) => shortNegativeForm.Value;

    private ShortNegativeForm(string value)
    {
        Value = value;
    }

    public static bool Is(Text text)
    {
        return text.GetWord().EndsWith("n't");
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