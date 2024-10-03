using Domain.Common.Models;
using Domain.Practice.Exercises.Errors;
using ErrorOr;

namespace Domain.Practice.Exercises.ValueObjects;

public sealed class EngPhrase : ValueObject
{
    public string Value { get; }

    private EngPhrase(string value)
    {
        Value = value;
    }

    public static ErrorOr<EngPhrase> Create(string value)
    {
        return value
            .ToErrorOr()
            .FailIf(string.IsNullOrWhiteSpace, ExerciseErrors.EmptyEngPhrase)
            .Then(x => new EngPhrase(x));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}