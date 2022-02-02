using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne_Relation
{
    internal class SchoolContext : DbContext
    {
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentAddress> StudentAddress { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BookCatagory> BooksCatagory { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Catagory> Catagory { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SI2PJCE;Database=LibraryDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Books>().HasKey("BookId");
            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author);

            modelBuilder.Entity<BookCatagory>()
           .HasKey(bc => new { bc.BookId, bc.CategoryId });

            modelBuilder.Entity<BookCatagory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCatagory>()
                .HasOne(bc => bc.Catagory)
                .WithMany(c => c.BookCatagory)
                .HasForeignKey(bc => bc.CategoryId);
        }

    }

}

