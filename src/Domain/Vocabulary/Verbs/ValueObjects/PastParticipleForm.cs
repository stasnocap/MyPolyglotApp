using Domain.Common.Models;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Verbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.Verbs.ValueObjects;

public sealed class PastParticipleForm : ValueObject
{
    public string Value { get; }
    
    public static explicit operator string(PastParticipleForm pastParticipleForm) => pastParticipleForm.Value;

    private PastParticipleForm(string value)
    {
        Value = value;
    }
    
    public static bool Is(Text text)
    {
        return text.Value.EndsWith("ed");
    }

    public static ErrorOr<PastParticipleForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return VerbErrors.EmptyPastParticipleForm;
        }

        return new PastParticipleForm(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}