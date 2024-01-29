namespace OnlineFood.Application.DTOs.OrderItems;

public class OrderItemDTO
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string Title { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }
}
