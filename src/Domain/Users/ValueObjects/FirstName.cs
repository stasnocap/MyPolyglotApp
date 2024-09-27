using Domain.Common.Models;
using ErrorOr;

namespace Domain.Users.ValueObjects;

public sealed class FirstName : ValueObject
{
    public string Value { get; }

    private FirstName(string value)
    {
        Value = value;
    }

    public static ErrorOr<FirstName> Create(string value)
    {
        return new FirstName(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}