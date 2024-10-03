using Domain.Common.Models;
using ErrorOr;

namespace Domain.Identity.ValueObjects;

public sealed class PasswordHash : ValueObject
{
    public string Value { get; }

    private PasswordHash(string value)
    {
        Value = value;
    }

    public static ErrorOr<PasswordHash> Create(string value)
    {
        return new PasswordHash(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}