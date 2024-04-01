using Microsoft.AspNetCore.Mvc;

namespace ECommerceBase.DiscountAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscountController : ControllerBase
    {
        private readonly List<Discount> Discounts = new()
        {
            new() { Id = 1, ProductId = 1, Amount = 1000, ValidUntil = DateTime.UtcNow.AddDays(7) },
            new() { Id = 2, ProductId = 3, Amount = 500, ValidUntil = DateTime.UtcNow.AddDays(14) },
        };

        [HttpGet("{id}")]
        public Discount? Get(int id) => Discounts.FirstOrDefault(f => f.ProductId == id);
    }
}
