namespace ECommerceBase.ProductAPI
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
