using Domain.Common.Models;

namespace Domain.Practice.Exercises.ValueObjects;

public sealed class ExerciseId : ValueObject
{
    public Guid Value { get; }

    private ExerciseId(Guid value)
    {
        Value = value;
    }
    
    public static ExerciseId Create(Guid id)
    {
        return new(id);
    }

    public static ExerciseId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}