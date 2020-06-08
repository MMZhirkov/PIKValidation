using DataModel;
using System.Data.Entity;

namespace AuthWCF.Context
{
    public class UserContext : DbContext
    {
        public UserContext(string connectionString) : base(connectionString)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}