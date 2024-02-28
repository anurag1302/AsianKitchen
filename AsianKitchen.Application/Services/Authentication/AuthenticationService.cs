using System;
using System.Runtime.ExceptionServices;
using AsianKitchen.Application.Common.Interfaces;
using AsianKitchen.Application.Common.Persistence;
using AsianKitchen.Domain;

namespace AsianKitchen.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator,
                                 IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    public AuthenticationResult Login(string email, string password)
    {
        
        var user = _userRepository.GetUserByEmail(email);
        if(user is null)
        {
            throw new Exception("User not found");
        }
        if(user.Password != password)
        {
            throw new Exception("Incorrect user id/password");
        }

        var userId = user.Id;
        var token = _jwtTokenGenerator.GenerateJwtToken(userId, email);

        return new AuthenticationResult
        {
            Id = userId,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Token = token
        };
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        if(_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User already exists");
        }

        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        _userRepository.Add(user);

        return new AuthenticationResult
        {
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Token = "token"
        };
    }
}