using DataAccessLayer.Interfaces;

namespace BusinessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
    }
}
