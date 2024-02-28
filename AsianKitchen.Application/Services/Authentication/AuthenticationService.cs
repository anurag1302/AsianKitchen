using System;
using System.Runtime.ExceptionServices;
using AsianKitchen.Application.Common.Interfaces;

namespace AsianKitchen.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public AuthenticationResult Login(string email, string password)
    {
        var userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateJwtToken(userId, email);

        return new AuthenticationResult
        {
            Id = userId,
            FirstName = "firstName",
            LastName = "lastName",
            Email = email,
            Token = token
        };
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResult
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Token = "token"
        };
    }
}