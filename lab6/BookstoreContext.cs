using Microsoft.EntityFrameworkCore;

namespace Lab6
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Change the Database name to Lab6DB so it doesn't conflict with your Lab5 database
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Lab6DB;Trusted_Connection=True;");
        }
    }
}