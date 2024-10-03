using Domain.Common.Models;
using ErrorOr;

namespace Domain.Identity.ValueObjects;

public sealed class Email : ValueObject
{
    public string Value { get; }

    private Email(string value)
    {
        Value = value;
    }

    public static ErrorOr<Email> Create(string value)
    {
        return new Email(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}