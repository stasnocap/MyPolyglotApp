using Domain.Common.Models;
using Domain.Practice.Lessons.Errors;
using ErrorOr;

namespace Domain.Practice.Lessons.ValueObjects;

public sealed class LessonNumber : ValueObject
{
    public int Value { get; }

    public static explicit operator int(LessonNumber lessonNumber) => lessonNumber.Value;

    private LessonNumber(int value)
    {
        Value = value;
    }
    
    public static ErrorOr<LessonNumber> Create(int value)
    {
        if (value < 1)
        {
            return LessonErrors.NegativeNumber;
        }
        
        return new LessonNumber(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}