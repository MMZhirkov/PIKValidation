using DataModel;
using System.Data.Entity;

namespace OAuthWebAngularJS.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base("Users")
        {
        }

        public IDbSet<User> Users { get; set; }
    }
}