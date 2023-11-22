using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Specifications
{
    public class ProductWithFileterForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFileterForCountSpecification(ProductSpecParams productParams) : base(x =>
         !productParams.CategoryId.HasValue || x.CategoryId == productParams.CategoryId)
        {
        }
    }
}
