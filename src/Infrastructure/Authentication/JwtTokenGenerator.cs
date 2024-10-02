using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.Common.Interfaces.Authentication;
using Application.Common.Interfaces.Services;
using Domain.Users;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Authentication;

public class JwtTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettings> settings) : IJwtTokenGenerator
{
    public string GenerateToken(User user)
    {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.Value.Secret)),
            SecurityAlgorithms.HmacSha256);
        
        var claims = new Claim[]
        {
            new(JwtRegisteredClaimNames.Sub, user.Id.Value.ToString()),
            new(JwtRegisteredClaimNames.GivenName, user.FirstName.Value),
            new(JwtRegisteredClaimNames.FamilyName, user.LastName.Value),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var securityToken = new JwtSecurityToken(issuer: "Music", 
            audience: settings.Value.Audience,
            expires: dateTimeProvider.UtcNow.AddMinutes(settings.Value.ExpiryMinutes),
            claims: claims, 
            signingCredentials: signingCredentials);

        return new JwtSecurityTokenHandler().WriteToken(securityToken);
    }
}