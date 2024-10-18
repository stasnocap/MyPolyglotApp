using Application.Common.Interfaces.Services;
using Domain.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services;

public class UserContext(
    UserManager<User> _userManager,
    IHttpContextAccessor _httpContextAccessor) : IUserContext
{
    public Guid? GetCurrentUserId()
    {
        if (_httpContextAccessor.HttpContext is null)
        {
            return null;
        }

        var userId = _userManager.GetUserId(_httpContextAccessor.HttpContext.User);

        if (userId is null)
        {
            return null;
        }

        return Guid.Parse(userId);
    }
}