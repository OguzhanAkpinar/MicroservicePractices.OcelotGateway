namespace ECommerceBase.DiscountAPI
{
    public class Discount
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
        public DateTime ValidUntil { get; set; }
    }
}
