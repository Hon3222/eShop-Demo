
using eShop_V1.Models;
using Microsoft.EntityFrameworkCore;

namespace eShop_V1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Market> Markets { get; set; }
    }
}
