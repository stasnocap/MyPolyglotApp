using Domain.Users.ValueObjects;

namespace Application.Common.Interfaces.Services;

public interface IUserContext
{
    UserId GetCurrentUserId();
}