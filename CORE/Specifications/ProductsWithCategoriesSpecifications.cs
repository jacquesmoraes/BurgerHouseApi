using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Specifications
{
    public class ProductsWithCategoriesSpecifications : BaseSpecification<Product>
    {
        public ProductsWithCategoriesSpecifications(int? categoryId) : base (x => x.CategoryId == categoryId ) 
        {
            AddIncludes(x => x.Category);
        }

        public ProductsWithCategoriesSpecifications(int id) : base(x => x.Id == id)
        {
            AddIncludes(x => x.Category);
        }
    }
}
