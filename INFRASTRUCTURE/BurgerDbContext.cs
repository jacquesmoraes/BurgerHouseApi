using CORE.Entities;
using Microsoft.EntityFrameworkCore;

namespace INFRASTRUCTURE;
public class BurgerDbContext : DbContext
{
  
    public BurgerDbContext(DbContextOptions<BurgerDbContext> options) : base(options)
    {
    }

    DbSet<Product> Products { get; set; }   
    DbSet<Category> Categories { get; set; }


   
}
