using MediatR;

namespace OnlineFood.Application.Features.OrderItems.Commands.Requests;

public class DeleteOrderItemCommand : IRequest<bool>
{
	public int Id { get; set; }
}
