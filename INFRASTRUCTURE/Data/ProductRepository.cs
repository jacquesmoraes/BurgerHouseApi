using CORE.Entities;
using CORE.Interfaces;
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

        public IReadOnlyList<Product> GetProduct()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Category> GetProductsCategories()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Type> GetProductsTypes()
        {
            throw new NotImplementedException();
        }
    }
}
