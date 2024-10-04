using Domain.Common.Models;
using Domain.Vocabulary.PrimaryVerbs.Errors;
using ErrorOr;

namespace Domain.Vocabulary.PrimaryVerbs.ValueObjects;

public class AdditionalForm : ValueObject
{
    public string Value { get; }
    
    public static explicit operator string(AdditionalForm additionalForm) => additionalForm.Value;

    private AdditionalForm(string value)
    {
        Value = value;
    }

    public static ErrorOr<AdditionalForm> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return PrimaryVerbErrors.EmptyAdditionalForm;
        }

        return new AdditionalForm(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}