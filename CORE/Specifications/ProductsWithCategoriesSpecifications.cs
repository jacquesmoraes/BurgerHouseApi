using CORE.Entities;

namespace CORE.Specifications
{
    public class ProductsWithCategoriesSpecifications : BaseSpecification<Product>
    {
        public ProductsWithCategoriesSpecifications(ProductSpecParams productParams) : 
            base (x =>
            (string.IsNullOrEmpty(productParams.Search) || x.ProductName.ToLower().Contains(productParams.Search)) &&
            (!productParams.CategoryId.HasValue || x.CategoryId == productParams.CategoryId ))
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
