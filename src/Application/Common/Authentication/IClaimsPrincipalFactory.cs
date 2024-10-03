using System.Security.Claims;
using Domain.Identity;

namespace Application.Common.Authentication;

public interface IClaimsPrincipalFactory
{
    ClaimsPrincipal Create(User user);
}