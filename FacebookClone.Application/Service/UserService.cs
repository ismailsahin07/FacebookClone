using FacebookClone.Application.Dtos;
using FacebookClone.Application.Interfaces;
using FacebookClone.Domain.Entities;

namespace FacebookClone.Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> LoginUserAsync(UserLoginDto LoginDto)
        {
            var user = await _userRepository.GetUserByEmail(LoginDto.Email);

            if (user == null) return null;

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(LoginDto.Password, user.PasswordHash);

            if (!isPasswordValid) return null;

            return user;
        }

        public async Task<bool> RegisterUserAsync(UserRegistrationDto RegisterDto)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(RegisterDto.Password);

            var user = new User
            {
                Name = RegisterDto.Name,
                Surname = RegisterDto.Surname,
                Email = RegisterDto.Email,
                Username = RegisterDto.Email,
                PasswordHash = hashedPassword
            };

            return await _userRepository.AddUserAsync(user);
        }
    }
}
