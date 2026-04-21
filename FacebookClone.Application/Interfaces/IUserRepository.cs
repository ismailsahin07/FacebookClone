using FacebookClone.Domain.Entities;

namespace FacebookClone.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> AddUserAsync(User user);
        Task<User?> GetUserByEmail(string email);
    }
}
