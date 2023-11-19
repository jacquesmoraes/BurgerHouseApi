using CORE.Entities;
using CORE.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRASTRUCTURE.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly BurgerDbContext _context;

        public ProductRepository(BurgerDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Product>> GetProducts()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
     
        public async Task<IReadOnlyList<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        
    }
}
