using DataAccessLayer.Interfaces;
using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories
{
    // shared base repository for the purpose of not repeating the code in every repo
    public class BaseRepository<T> : IBaseRepository<T> where T :class
    {
        protected readonly DataContext _context;
        protected readonly DbSet<T> DBSet;
        public BaseRepository(DataContext context)
        {
            _context = context;
            DBSet = _context.Set<T>();
        }
    }
}