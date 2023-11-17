using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.OrderItems;

public class OrderItem : BaseEntity
{
    public int OrderId { get; set; }
    public string Title { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
}
