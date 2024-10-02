using System.Security.Claims;
using Application.Common.Authentication;
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
    IPasswordHasher<User> _passwordHasher,
    IClaimsPrincipalFactory _claimsPrincipalFactory)
    : IRequestHandler<RegisterCommand, ErrorOr<ClaimsPrincipal>>
{
    public async Task<ErrorOr<ClaimsPrincipal>> Handle(RegisterCommand request,
        CancellationToken cancellationToken)
    {
        var errors = new List<Error>();

        var errorOrEmail = Email.Create(request.Email);
        errors.AddRange(errorOrEmail.ErrorsOrEmptyList);
        var errorOrFirstName = FirstName.Create(request.FirstName);
        errors.AddRange(errorOrFirstName.ErrorsOrEmptyList);
        var errorOrLastName = LastName.Create(request.LastName);
        errors.AddRange(errorOrLastName.ErrorsOrEmptyList);
        var errorOrPassword = Password.Create(request.Password);
        errors.AddRange(errorOrPassword.ErrorsOrEmptyList);

        if (errors.Count != 0)
        {
            return errors;
        }

        if (await _userRepository.SingleOrDefaultAsync(errorOrEmail.Value, cancellationToken) is not null)
        {
            return UserErrors.DuplicateEmail;
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

        return _claimsPrincipalFactory.Create(user);
    }
}