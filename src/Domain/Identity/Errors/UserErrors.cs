using ErrorOr;

namespace Domain.Identity.Errors;

public static partial class UserErrors
{
    public static Error DuplicateEmail => Error.Conflict(code: "User.DuplicateEmail", description: "Email is already in use.");

    public static Error NotFound => Error.NotFound(code: "User.NotFound", description: "User with given email does not exist.");
}