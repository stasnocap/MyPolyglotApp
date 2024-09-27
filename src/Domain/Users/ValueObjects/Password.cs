using Domain.Common.Models;
using ErrorOr;

namespace Domain.Users.ValueObjects;

public sealed class Password : ValueObject
{
    public string Value { get; }

    private Password(string value)
    {
        Value = value;
    }

    public static ErrorOr<Password> Create(string value)
    {
        return new Password(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}