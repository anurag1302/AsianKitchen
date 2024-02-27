using System;

namespace AsianKitchen.Application.Services.Authentication;

public class AuthenticationResult
{
    public Guid Id{get;set;} = Guid.NewGuid();
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string Email {get;set;}
    public string Token {get;set;}

}