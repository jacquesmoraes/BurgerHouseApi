using CORE.Entities;
using CORE.Interfaces;
using INFRASTRUCTURE;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    public class ProductsController : BaseApiController
    {
        private readonly IProductRepository _prodRepo;
        public ProductsController(IProductRepository prodRepo)
        {
           _prodRepo= prodRepo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
           var product = await _prodRepo.GetProducts();
            return Ok(product); 
        }

        [HttpGet("{id}")]

        public string GetProduct(int id)
        {
            return "this will be a product number " + id;
        }

        [HttpGet("categories")]
        public async Task<ActionResult<IReadOnlyList<Category>>> GetCategory()
        {
            return Ok(await _prodRepo.GetCategoriesAsync());
        }

       
    }
}
