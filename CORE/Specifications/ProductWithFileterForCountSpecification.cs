using CORE.Entities;

namespace CORE.Specifications
{
    public class ProductWithFileterForCountSpecification : BaseSpecification<Product>
    {
        public ProductWithFileterForCountSpecification(ProductSpecParams productParams) : base(x =>
         (string.IsNullOrEmpty(productParams.Search) || x.ProductName.ToLower().Contains(productParams.Search)) &&
         (!productParams.CategoryId.HasValue || x.CategoryId == productParams.CategoryId))
        {
        }
    }
}
