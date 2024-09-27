using Domain.Common.Models;
using ErrorOr;
using Domain.Lessons.Errors;

namespace Domain.Lessons.ValueObjects;

public sealed class LessonName : ValueObject
{
    public string Value { get; }

    private LessonName(string value)
    {
        Value = value;
    }
    
    public static ErrorOr<LessonName> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return LessonErrors.EmptyName;
        }
        
        return new LessonName(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}