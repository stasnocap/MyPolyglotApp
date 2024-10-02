using Application.Authentication.Common;
using Application.Common.Interfaces.Authentication;
using Application.Common.Interfaces.Persistence;
using Domain.Users;
using Domain.Users.Errors;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Authentication.Queries.Login;

public class LoginQueryHandler(IUserRepository _userRepository, IJwtTokenGenerator _jwtTokenGenerator, IPasswordHasher<User> _passwordHasher)
    : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.SingleOrDefaultAsync(request.Email, cancellationToken);

        if (user is null)
        {
            return UserErrors.NotFound;
        }

        var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash.Value, request.Password);

        if (passwordVerificationResult == PasswordVerificationResult.Failed)
        {
            return AuthenticationErrors.InvalidCredentials;
        }

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, request.Email, token);
    }
}