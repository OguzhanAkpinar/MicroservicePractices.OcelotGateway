using Microsoft.AspNetCore.Mvc;

namespace ECommerceBase.ProductAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly List<Product> Products = new()
        {
            new() { Id = 1, CategoryId = 1, Title = "Huawei Matebook D14 2024", Price = 21000 },
            new() { Id = 2, CategoryId = 2, Title = "Xiaomi Redmi 12C", Price = 5200 },
            new() { Id = 3, CategoryId = 3, Title = "Monster Aryond A27", Price = 6500 },
        };

        [HttpGet]
        public IEnumerable<Product> Get() => Products;

        [HttpGet("{id}")]
        public Product? Get(int id) => Products.FirstOrDefault(f => f.Id == id);
    }
}
