using Domain.Common.Models;

namespace Domain.Lessons.ValueObjects;

public sealed class LessonId : ValueObject
{
    public Guid Value { get; }

    private LessonId(Guid value)
    {
        Value = value;
    }
    
    public static LessonId Create(Guid id)
    {
        return new(id);
    }

    public static LessonId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}