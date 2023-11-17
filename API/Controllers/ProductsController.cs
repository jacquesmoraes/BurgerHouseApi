using CORE.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    public class ProductsController : BaseApiController
    {

        [HttpGet]
        public string GetProducts()
        {
            return "this is a list of products";
        }

        [HttpGet("{id}")]

        public string GetProduct(int id)
        {
            return "this will be a product number " + id;
        }
    }
}
