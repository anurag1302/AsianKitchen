using AsianKitchen.Application.Services.Authentication;
using AsianKitchen.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace AsianKitchen.Api;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest loginRequest)
    {
        var response = _authenticationService.Login(loginRequest.Email, loginRequest.Password);

        var result = new AuthenticationResponse
        {
            Id = response.Id,
            FirstName = response.FirstName,
            LastName = response.LastName,
            Email = response.Email,
            Token = response.Token
        };

        return Ok(result);
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {
        var response = _authenticationService.Register(registerRequest.FirstName, 
        registerRequest.LastName, 
        registerRequest.Email, 
        registerRequest.Password);

        var result = new AuthenticationResponse
        {
            Id = response.Id,
            FirstName = response.FirstName,
            LastName = response.LastName,
            Email = response.Email,
            Token = response.Token
        };

        return Ok(result);
    }

    [HttpGet("index")]
    public IActionResult Index()
    {
        return Ok("index");
    }

}