using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        // default user created when running the application for the first time
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User()
                {
                    Id = 1, 
                    Username = "admin",
                    PasswordHash = "$2a$11$DkRr4xS4/atWo3rMM9ljLOrIaWoRbmJqyHC42AvVIm7FLS82DwlJi",
                }
            );
        }
    }
}
