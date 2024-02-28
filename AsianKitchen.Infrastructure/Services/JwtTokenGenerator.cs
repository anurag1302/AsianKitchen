using System.Security.Claims;
using AsianKitchen.Application.Common.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace AsianKitchen.Infrastructure.Services;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    public string GenerateJwtToken(Guid userId, string email)
    {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes("x5PuloU5mFkmjQH7IsbQrkCJbuNoqzzJ")),
            SecurityAlgorithms.HmacSha256
        );

        var claims = new[]
        {
           new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
           new Claim(JwtRegisteredClaimNames.Email, email)
        };

        var securityToken = new JwtSecurityToken(
            issuer: "AsianKitchen",
            audience: "AsianKitchen",
            expires: DateTime.Now.AddMinutes(60),
            claims: claims,
            signingCredentials: signingCredentials
        );

        return new JwtSecurityTokenHandler().WriteToken(securityToken);

    }
}