using System;

namespace AsianKitchen.Application.Common.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateJwtToken(Guid userId, string email);
}