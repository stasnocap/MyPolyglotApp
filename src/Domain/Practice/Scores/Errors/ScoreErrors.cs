using ErrorOr;

namespace Domain.Practice.Scores.Errors;

public static class ScoreErrors
{
    public static readonly Error NegativeCorrectNumber = Error.Validation($"{nameof(Score)}.{nameof(NegativeCorrectNumber)}", "Correct number can't be negative.");
    public static readonly Error NegativeWrongNumber = Error.Validation($"{nameof(Score)}.{nameof(NegativeWrongNumber)}", "Wrong number can't be negative.");
}