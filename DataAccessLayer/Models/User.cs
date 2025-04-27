namespace DataAccessLayer.Models
{
    public class User 
    {
        public long Id { get; set; }
        public string Username { get; set; }
        // password is always saved as hash for secured reasons 
        public string PasswordHash { get; set; }
    }
} 