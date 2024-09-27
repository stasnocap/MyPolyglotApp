using ErrorOr;

namespace Domain.Exercises.Errors;

public static class WordErrors
{
    public static readonly Error NegativeNumber = Error.Validation("Word.NegativeNumber", "Word number can't be negative or zero.");
}