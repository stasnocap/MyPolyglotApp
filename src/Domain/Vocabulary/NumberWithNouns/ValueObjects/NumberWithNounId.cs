using Domain.Common.Models;

namespace Domain.Vocabulary.NumberWithNouns.ValueObjects;

public sealed class NumberWithNounId : ValueObject
{
    public Guid Value { get; }

    private NumberWithNounId(Guid value)
    {
        Value = value;
    }

    public static NumberWithNounId Create(Guid value)
    {
        return new NumberWithNounId(value);
    }

    public static NumberWithNounId CreateUnique()
    {
        return new NumberWithNounId(Guid.NewGuid());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}