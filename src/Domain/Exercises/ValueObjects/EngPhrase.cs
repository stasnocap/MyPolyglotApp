using Domain.Common.Models;
using Domain.Exercises.Errors;
using ErrorOr;

namespace Domain.Exercises.ValueObjects;

public sealed class EngPhrase : ValueObject
{
    public string Value { get; }

    private EngPhrase(string value)
    {
        Value = value;
    }

    public static ErrorOr<EngPhrase> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return ExerciseErrors.EmptyEngPhrase;
        }

        return new EngPhrase(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}