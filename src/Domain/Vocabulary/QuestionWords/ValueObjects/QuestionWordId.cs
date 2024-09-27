using Domain.Common.Models;

namespace Domain.Vocabulary.QuestionWords.ValueObjects;

public sealed class QuestionWordId : ValueObject
{
    public Guid Value { get; }

    private QuestionWordId(Guid value)
    {
        Value = value;
    }

    public static QuestionWordId Create(Guid value)
    {
        return new QuestionWordId(value);
    }
    
    public static QuestionWordId CreateUnique()
    {
        return new QuestionWordId(Guid.NewGuid());
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}