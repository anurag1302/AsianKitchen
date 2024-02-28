using System.Collections.Generic;
using System.Linq;
using AsianKitchen.Application.Common.Persistence;
using AsianKitchen.Domain;

namespace AsianKitchen.Infrastructure.Services.Persistence;

public class UserRepository : IUserRepository
{
    private static List<User> users = new();
    public void Add(User user)
    {
        users.Add(user);
    }

    public User GetUserByEmail(string email)
    {
        return users.SingleOrDefault(x => x.Email == email);
    }
}