using API_BasicAuthentication.Model;
using API_BasicAuthentication.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace API_BasicAuthentication.Model
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<UserRecord> userRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SI2PJCE;Database=UserAuthDb;Trusted_Connection=True;");
        }

    }
}
