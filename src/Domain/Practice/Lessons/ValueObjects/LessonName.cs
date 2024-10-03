using Domain.Common.Models;
using Domain.Practice.Lessons.Errors;
using ErrorOr;

namespace Domain.Practice.Lessons.ValueObjects;

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