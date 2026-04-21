using FacebookClone.Application.Interfaces;
using FacebookClone.Domain.Entities;
using FacebookClone.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FacebookClone.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await _context.Users.SingleOrDefaultAsync(m => m.Email == email);
        }
    }
}
