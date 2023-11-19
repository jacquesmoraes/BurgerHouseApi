using CORE.Entities;
using Microsoft.EntityFrameworkCore;

namespace INFRASTRUCTURE;
public class BurgerDbContext : DbContext
{
  
    public BurgerDbContext(DbContextOptions<BurgerDbContext> options) : base(options)
    {
    }

     public DbSet<Product> Products { get; set; }   
    public DbSet<Category> Categories { get; set; }

   
}
