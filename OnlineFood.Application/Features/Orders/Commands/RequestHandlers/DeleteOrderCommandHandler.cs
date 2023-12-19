using MediatR;
using OnlineFood.Application.Features.Orders.Commands.Requests;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.InterfaceRepositories.Orders;

namespace OnlineFood.Application.Features.Orders.Commands.RequestHandlers;

public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, bool>
{
	private readonly IOrderRepository _OrderRepository;

	public DeleteOrderCommandHandler(IOrderRepository OrderRepository)
	{
		this._OrderRepository = OrderRepository;
	}

	public Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
	{
		Order Order = new Order { Id = request.Id };
		return _OrderRepository.Delete(Order);
	}
}