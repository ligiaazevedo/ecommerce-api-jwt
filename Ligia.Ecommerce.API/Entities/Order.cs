using Ligia.Ecommerce.API.Entities.Enums;

namespace Ligia.Ecommerce.API.Entities
{
    public class Order : BaseEntity
    {
        public double TotalAmount { get; set; }
        public DateTime CreatedBy { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Created;
        public int ClientId { get; set; }  
        public Client Client { get; set; }  

    }
}
