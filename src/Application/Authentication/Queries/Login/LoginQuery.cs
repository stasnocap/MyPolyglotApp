using System.Security.Claims;
using ErrorOr;
using MediatR;

namespace Application.Authentication.Queries.Login;

public record LoginQuery(string Email, string Password) : IRequest<ErrorOr<ClaimsPrincipal>>;