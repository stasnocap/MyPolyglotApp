using Application.Authentication.Common;
using Application.Common.Interfaces.Authentication;
using Application.Common.Interfaces.Persistence;
using Domain.Users;
using Domain.Users.Errors;
using Domain.Users.ValueObjects;
using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Authentication.Commands.Register;

public class RegisterCommandHandler(
    IUserRepository _userRepository,
    IJwtTokenGenerator _jwtTokenGenerator,
    IPasswordHasher<User> _passwordHasher)
    : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand request,
        CancellationToken cancellationToken)
    {
        if (await _userRepository.SingleOrDefaultAsync(request.Email, cancellationToken) is not null)
        {
            return UserErrors.DuplicateEmail;
        }

        var errors = new List<Error>();

        var errorOrFirstName = FirstName.Create(request.FirstName);
        errors.AddRange(errorOrFirstName.ErrorsOrEmptyList);
        var errorOrLastName = LastName.Create(request.LastName);
        errors.AddRange(errorOrLastName.ErrorsOrEmptyList);
        var errorOrEmail = Email.Create(request.Email);
        errors.AddRange(errorOrEmail.ErrorsOrEmptyList);
        var errorOrPassword = Password.Create(request.Password);
        errors.AddRange(errorOrPassword.ErrorsOrEmptyList);

        if (errors.Any())
        {
            return errors;
        }

        var firstName = errorOrFirstName.Value;
        var lastName = errorOrLastName.Value;
        var email = errorOrEmail.Value;
        var password = errorOrPassword.Value;

        var user = User.Create(firstName, lastName, email);

        var errorOrPasswordHash = PasswordHash.Create(_passwordHasher.HashPassword(user, password.Value));
        errors.AddRange(errorOrPassword.ErrorsOrEmptyList);

        if (errors.Any())
        {
            return errors;
        }

        user.PasswordHash = errorOrPasswordHash.Value;

        await _userRepository.AddAsync(user, cancellationToken);

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(user, request.Email, token);
    }
}