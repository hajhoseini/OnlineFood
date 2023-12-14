using MediatR;

namespace OnlineFood.Application.Features.Orders.Commands.Requests;

public class DeleteOrderCommand : IRequest<bool>
{
	public int Id { get; set; }
}
