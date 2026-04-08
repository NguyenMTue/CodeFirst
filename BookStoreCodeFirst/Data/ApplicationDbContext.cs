using Microsoft.EntityFrameworkCore;
using BookStoreCodeFirst.Models;

namespace BookStoreCodeFirst.Data
{
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Book> Books { get; set; }
    }
}