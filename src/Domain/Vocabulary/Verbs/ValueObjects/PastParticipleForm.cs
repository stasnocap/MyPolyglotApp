using Domain.Common.Models;
using Domain.Vocabulary.Verbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.Verbs.ValueObjects;

public sealed class PastParticipleForm : ValueObject
{
    public string Value { get; }

    private PastParticipleForm(string value)
    {
        Value = value;
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