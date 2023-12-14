using MediatR;
using OnlineFood.Domain.Entities.OrderItems;

namespace OnlineFood.Application.Features.OrderItems.Queries.Requests;

public class GetOrderItemQuery : IRequest<OrderItem>
{
	public int Id { get; set; }
}
