using CORE.Entities;
using System.Collections.Generic;

namespace CORE.Interfaces
{
    public interface IProductRepository 
    {
        public IReadOnlyList<Product> GetProduct();
        public IReadOnlyList<Category> GetProductsCategories();

        public IReadOnlyList<Type> GetProductsTypes();

    }
}
