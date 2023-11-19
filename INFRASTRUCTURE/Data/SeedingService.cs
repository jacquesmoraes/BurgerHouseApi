using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace INFRASTRUCTURE.Data
{
    public class SeedingService
    {
        public static async Task Seed(BurgerDbContext context)
        {
            if(!context.Products.Any())
            {
                var productsData = File.ReadAllText("../INFRASTRUCTURE/Data/SeedingData/Products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                context.AddRange(products);
            }

            if (!context.Categories.Any())
            {
                var CategoriesData = File.ReadAllText("../INFRASTRUCTURE/Data/SeedingData/Category.json");
                var Category = JsonSerializer.Deserialize<List<Category>>(CategoriesData);

                context.AddRange(Category);
            }

            if(context.ChangeTracker.HasChanges())
            {
                await context.SaveChangesAsync();
            }
        }
    }
}
