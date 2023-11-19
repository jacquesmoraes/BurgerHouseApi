using CORE.Entities;
using System.Collections.Generic;

namespace CORE.Interfaces
{
    public interface IProductRepository 
    {
        Task<IReadOnlyList<Product>> GetProducts();
        Task<IReadOnlyList<Category>> GetCategoriesAsync();


    }
}
