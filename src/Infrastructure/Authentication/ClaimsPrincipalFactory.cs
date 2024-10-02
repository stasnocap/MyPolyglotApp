using System.Security.Claims;
using Application.Common.Authentication;
using Domain.Users;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Infrastructure.Authentication;

public class ClaimsPrincipalFactory : IClaimsPrincipalFactory
{
    public ClaimsPrincipal Create(User user)
    {
        List<Claim> claims = [
            // new(nameof(User.FirstName), user.FirstName.Value),
            // new(nameof(User.LastName), user.LastName.Value),
            // new(nameof(User.Email), user.Email.Value),
        ];
                
        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

        return claimsPrincipal;
    }
}