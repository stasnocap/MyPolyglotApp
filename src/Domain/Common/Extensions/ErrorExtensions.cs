using ErrorOr;

namespace Domain.Common.Extensions;

public static class ErrorExtensions
{
    public static ErrorOr<TValue> ElseAccumulate<TValue>(this ErrorOr<TValue> errorOr, List<Error> errors)
    {
        return errorOr.Else(e =>
        {
            errors.AddRange(e);
            return e;
        });
    }
}