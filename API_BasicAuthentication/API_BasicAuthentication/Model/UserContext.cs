using API_BasicAuthentication.Model;
using API_BasicAuthentication.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace API_BasicAuthentication.Model
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {
            
            
        }
        public DbSet<UserRecord> userRecords { get; set; }

    }
}
