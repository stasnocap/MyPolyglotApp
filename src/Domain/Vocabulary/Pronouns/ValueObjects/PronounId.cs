using Domain.Common.Models;

namespace Domain.Vocabulary.Pronouns.ValueObjects;

public sealed class PronounId : ValueObject
{
    public Guid Value { get; }

    private PronounId(Guid value)
    {
        Value = value;
    }

    public static PronounId Create(Guid value)
    {
        return new PronounId(value);
    }
    
    public static PronounId CreateUnique()
    {
        return new PronounId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}