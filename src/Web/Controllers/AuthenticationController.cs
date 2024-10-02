using Application.Authentication.Commands.Register;
using Application.Authentication.Queries.Login;
using Contracts.Authentication;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[Route("auth")]
[AllowAnonymous]
public class AuthenticationController(ISender _mediatr, IMapper _mapper) : ApiController
{
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = _mapper.Map<RegisterCommand>(request);

        var result = await _mediatr.Send(command, HttpContext.RequestAborted);

        return result.Match(SignIn, Problem);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = _mapper.Map<LoginQuery>(request);

        var result = await _mediatr.Send(query, HttpContext.RequestAborted);

        return result.Match(SignIn, Problem);
    }
}