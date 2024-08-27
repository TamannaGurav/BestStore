using BestStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BestStore.Services
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
