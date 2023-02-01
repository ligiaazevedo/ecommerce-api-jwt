namespace Ligia.Ecommerce.API.Entities
{
    public class OrderDetail : BaseEntity
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalAmount { get; set; }
        public double Discount { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
