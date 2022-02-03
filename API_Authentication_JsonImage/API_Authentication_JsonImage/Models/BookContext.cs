using Microsoft.EntityFrameworkCore;

namespace API_Authentication_JsonImage.Models
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> option):base(option)
        {
            Database.EnsureCreated();// Ensures that the database is created
        }
        public DbSet<Books> Books { get; set; }//used to save query and instances of books
        public DbSet<UploadCustomerImageModel> UploadCustomerImageModels { get; set; }//used to save query and instances of books
        
    }
}
