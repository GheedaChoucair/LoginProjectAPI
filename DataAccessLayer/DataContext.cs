using DataAccessLayer.Configurations;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add default user in the first migration 
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
} 