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
        public ProductsWithCategoriesSpecifications(ProductSpecParams productParams) : base (x =>(!productParams.CategoryId.HasValue || x.CategoryId == productParams.CategoryId ))
        {
            AddIncludes(x => x.Category);
            ApplyPaging(productParams.PageSize * (productParams.PageIndex- 1) , productParams.PageSize);
        }

        public ProductsWithCategoriesSpecifications(int id) : base(x => x.Id == id)
        {
            AddIncludes(x => x.Category);
        }
    }
}
