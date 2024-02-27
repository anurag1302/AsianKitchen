using AsianKitchen.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AsianKitchen.Api;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login(LoginRequest loginRequest)
    {
        return Ok(loginRequest);
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest registerRequest)
    {
        return Ok(registerRequest);
    }

    [HttpGet("index")]
    public IActionResult Index()
    {
        return Ok("index");
    }

}