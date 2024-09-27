using Domain.Common.Models;

namespace Domain.Vocabulary.Languages.ValueObjects;

public sealed class LanguageId : ValueObject
{
    public Guid Value { get; }

    private LanguageId(Guid value)
    {
        Value = value;
    }

    public static LanguageId Create(Guid value)
    {
        return new LanguageId(value);
    }
    
    public static LanguageId CreateUnique()
    {
        return new LanguageId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}