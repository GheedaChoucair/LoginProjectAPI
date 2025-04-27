using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            User dbUser = await _context.Users.SingleOrDefaultAsync(u => u.Username == username);
            return dbUser;
        }
    }
}
