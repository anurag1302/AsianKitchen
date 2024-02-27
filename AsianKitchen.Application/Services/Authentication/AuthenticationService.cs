using System;
using System.Runtime.ExceptionServices;

namespace AsianKitchen.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult
        {
            Id = Guid.NewGuid(),
            FirstName = "firstName",
            LastName = "lastName",
            Email = email,
            Token = "token"
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