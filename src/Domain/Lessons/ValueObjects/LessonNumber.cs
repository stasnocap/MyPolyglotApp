using Domain.Common.Models;
using Domain.Lessons.Errors;
using ErrorOr;

namespace Domain.Lessons.ValueObjects;

public sealed class LessonNumber : ValueObject
{
    public int Value { get; }

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