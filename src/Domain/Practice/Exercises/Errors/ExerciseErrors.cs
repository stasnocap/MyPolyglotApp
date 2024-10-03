using ErrorOr;

namespace Domain.Practice.Exercises.Errors;

public static class ExerciseErrors
{
    public static readonly Error EmptyRusPhrase = Error.Validation("Exercise.EmptyRusPhrase", "Rus phrase can't be empty.");
}