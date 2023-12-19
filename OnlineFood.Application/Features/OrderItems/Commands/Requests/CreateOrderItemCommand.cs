using MediatR;

namespace OnlineFood.Application.Features.OrderItems.Commands.Requests;

public class CreateOrderItemCommand : IRequest<bool>
{
	public int Id { get; set; }
	public DateTime CreateDate { get; set; }
	public int OrderId { get; set; }
	public string Title { get; set; }
	public int Count { get; set; }
	public decimal Price { get; set; }
}
