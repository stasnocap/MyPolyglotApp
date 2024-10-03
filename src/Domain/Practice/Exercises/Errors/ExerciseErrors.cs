using ErrorOr;

namespace Domain.Practice.Exercises.Errors;

public static class ExerciseErrors
{
    public static readonly Error EmptyRusPhrase = Error.Validation("Exercise.EmptyRusPhrase", "Rus phrase can't be empty.");
    public static readonly Error EmptyEngPhrase = Error.Validation("Exercise.EmptyEngPhrase", "Eng phrase can't be empty.");
}