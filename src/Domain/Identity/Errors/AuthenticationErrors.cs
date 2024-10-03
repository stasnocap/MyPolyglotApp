using ErrorOr;

namespace Domain.Identity.Errors;

public static class AuthenticationErrors
{
    public static Error InvalidCredentials => Error.Unauthorized(code: "User.InvalidCredentials", description: "Invalid credentials.");
}