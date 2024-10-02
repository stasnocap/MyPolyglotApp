using System.Security.Claims;
using Application.Common.Interfaces.Services;
using Domain.Users.ValueObjects;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Services;

public class UserContext(IHttpContextAccessor _httpContextAccessor) : IUserContext
{
    public UserId GetCurrentUserId() => UserId.Create(Guid.Parse(_httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier)!));
}