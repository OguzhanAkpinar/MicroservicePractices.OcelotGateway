using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceBase.CategoryAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly List<Category> Categories = new()
        {
            new() { Id = 1, Title = "Laptop" },
            new() { Id = 2, Title = "Phone" },
            new() { Id = 3, Title = "Monitor" },
        };

        [HttpGet]
        public IEnumerable<Category> Get() => Categories;

        [HttpGet("{id}")]
        public Category? Get(int id) => Categories.FirstOrDefault(f => f.Id == id);
    }
}
