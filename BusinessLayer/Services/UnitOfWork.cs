using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataLayer;

namespace BusinessLayer.Services
{
    // centrall class for initializing all repositories
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        private IUserRepository UserRepository;

        public IUserRepository Users => UserRepository ?? new UserRepository(_context);
    }
}
