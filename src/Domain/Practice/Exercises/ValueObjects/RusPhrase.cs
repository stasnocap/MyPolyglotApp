using Domain.Common.Models;
using Domain.Practice.Exercises.Errors;
using ErrorOr;

namespace Domain.Practice.Exercises.ValueObjects;

public sealed class RusPhrase : ValueObject
{
    public string Value { get; }

    private RusPhrase(string value)
    {
        Value = value;
    }

    public static ErrorOr<RusPhrase> Create(string value)
    {
        return value
            .ToErrorOr()
            .FailIf(string.IsNullOrWhiteSpace, ExerciseErrors.EmptyRusPhrase)
            .Then(x => new RusPhrase(x));
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}