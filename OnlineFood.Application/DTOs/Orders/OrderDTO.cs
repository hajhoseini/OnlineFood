using OnlineFood.Common.Enums;

namespace OnlineFood.Application.DTOs.Orders;

public class OrderDTO
{
    public int Id { get; set; }
    public int Code { get; set; }
    public int CustomerId { get; set; }
    public int AddressId { get; set; }
    public int RestaurantId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public decimal OrderPrice { get; set; }
    public decimal SendPrice { get; set; }
    public decimal TotalPrice { get; set; }
    public PaymentTypeEnum PaymentType { get; set; }
    public OrderStatusEnum OrderStatus { get; set; }
}
