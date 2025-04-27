using DataAccessLayer.Models;

namespace DataAccessLayer.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetUserByUsernameAsync(string username);
    }
}
