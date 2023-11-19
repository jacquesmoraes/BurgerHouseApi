using CORE.Entities;
using CORE.Interfaces;
using CORE.Specifications;
using INFRASTRUCTURE;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    public class ProductsController : BaseApiController
    {
        private readonly IGenericRepository<Product> _prodRepository;
        private readonly IGenericRepository<Category> _categoryRepository;

        public ProductsController(IGenericRepository<Product> prodRepository, IGenericRepository<Category> categoryRepository)
        {
            _prodRepository = prodRepository;
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var prodWithCats = new ProductsWithCategoriesSpecifications();
           var product = await _prodRepository.ListAsync(prodWithCats);
            return Ok(product); 
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var spec = new ProductsWithCategoriesSpecifications(id);
            return await _prodRepository.GetEntityWithSpecs(spec);
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IReadOnlyList<Category>>> GetCategory()
        {
            return Ok(await _categoryRepository.ListAllAsync());
        }

       
    }
}
