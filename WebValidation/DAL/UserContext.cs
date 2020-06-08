using DataModel;
using System.Data.Entity;

namespace WebValidation.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        {
        }

        public IDbSet<User> Users { get; set; }
    }
}