using CORE.Entities;
using INFRASTRUCTURE;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class CategoryController : BaseApiController
    {
        private readonly BurgerDbContext _Context;
        public CategoryController(BurgerDbContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public List<Category> GetCategory()
        {
            return _Context.Categories.ToList();

        }

    }
}
