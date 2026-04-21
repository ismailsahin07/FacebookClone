using FacebookClone.Application.Dtos;
using FacebookClone.Domain.Entities;

namespace FacebookClone.Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> RegisterUserAsync(UserRegistrationDto registrationDto);
        Task<User?> LoginUserAsync(UserLoginDto loginDto);
    }
}
