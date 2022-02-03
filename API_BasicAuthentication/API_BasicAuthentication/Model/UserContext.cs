using API_BasicAuthentication.Model;
using API_BasicAuthentication.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace API_BasicAuthentication.Model
{
    public class UserContext:DbContext
    {
        public DbSet<UserRecord> userRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer()
        }

    }
}
