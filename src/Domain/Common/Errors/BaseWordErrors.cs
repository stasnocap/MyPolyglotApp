using ErrorOr;

namespace Domain.Common.Errors;

public static class BaseWordErrors
{
    public static readonly Error Empty = Error.Validation("BaseWord.Empty", "Word can't be empty.");
}