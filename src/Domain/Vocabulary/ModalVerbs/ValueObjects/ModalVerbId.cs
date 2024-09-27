using Domain.Common.Models;

namespace Domain.Vocabulary.ModalVerbs.ValueObjects;

public sealed class ModalVerbId : ValueObject
{
    public Guid Value { get; }

    private ModalVerbId(Guid value)
    {
        Value = value;
    }

    public static ModalVerbId Create(Guid value)
    {
        return new ModalVerbId(value);
    }
    
    public static ModalVerbId CreateUnique()
    {
        return new ModalVerbId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}