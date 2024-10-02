using System.Security.Claims;
using Domain.Users;

namespace Application.Common.Authentication;

public interface IClaimsPrincipalFactory
{
    ClaimsPrincipal Create(User user);
}