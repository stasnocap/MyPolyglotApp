using System.Security.Claims;
using Application.Common.Authentication;
using Application.Common.Interfaces.Persistence;
using Domain.Users;
using Domain.Users.Errors;
using Domain.Users.ValueObjects;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Authentication.Queries.Login;

public class LoginQueryHandler(IUserRepository _userRepository, IPasswordHasher<User> _passwordHasher, IClaimsPrincipalFactory _claimsPrincipalFactory)
    : IRequestHandler<LoginQuery, ErrorOr<ClaimsPrincipal>>
{
    public async Task<ErrorOr<ClaimsPrincipal>> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var errorOrEmail = Email.Create(request.Email);

        if (errorOrEmail.IsError)
        {
            return errorOrEmail.Errors;
        }

        var user = await _userRepository.SingleOrDefaultAsync(errorOrEmail.Value, cancellationToken);

        if (user is null)
        {
            return UserErrors.NotFound;
        }

        var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash.Value, request.Password);

        if (passwordVerificationResult == PasswordVerificationResult.Failed)
        {
            return AuthenticationErrors.InvalidCredentials;
        }
        
        return _claimsPrincipalFactory.Create(user);
    }
}