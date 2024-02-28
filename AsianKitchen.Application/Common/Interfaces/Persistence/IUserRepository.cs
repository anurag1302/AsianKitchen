using AsianKitchen.Domain;

namespace AsianKitchen.Application.Common.Persistence;

public interface IUserRepository
{
    void Add(User user);

    User GetUserByEmail(string email);
}