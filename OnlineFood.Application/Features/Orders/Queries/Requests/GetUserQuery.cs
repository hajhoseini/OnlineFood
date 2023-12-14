using MediatR;
using OnlineFood.Domain.Entities.Orders;

namespace OnlineFood.Application.Features.Orders.Queries.Requests;

public class GetOrderQuery : IRequest<Order>
{
	public int Id { get; set; }
}
