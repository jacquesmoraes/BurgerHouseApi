using CORE.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace INFRASTRUCTURE;
public class BurgerDbContext : DbContext
{
  
    public BurgerDbContext(DbContextOptions<BurgerDbContext> options) : base(options)
    {
    }

     public DbSet<Product> Products { get; set; }   
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
   
}
