using DataAccessLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetUserByUsernameAsync(string username);
    }
}
