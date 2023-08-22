using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ProductManagerDBContext : DbContext
    {
        public ProductManagerDBContext(DbContextOptions<ProductManagerDBContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
       /* public DbSet<Orders> Orders { get; set; }
        public DbSet<Company> Companies { get; set; }*/
    }
}
