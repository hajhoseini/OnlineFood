using MediatR;
using OnlineFood.Application.Features.OrderItems.Commands.Requests;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.InterfaceRepositories.OrderItems;

namespace OnlineFood.Application.Features.OrderItems.Commands.RequestHandlers;

public class DeleteOrderItemCommandHandler : IRequestHandler<DeleteOrderItemCommand, bool>
{
	private readonly IOrderItemRepository _OrderItemRepository;

	public DeleteOrderItemCommandHandler(IOrderItemRepository OrderItemRepository)
	{
		this._OrderItemRepository = OrderItemRepository;
	}

	public Task<bool> Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
	{
		OrderItem OrderItem = new OrderItem { Id = request.Id };
		return _OrderItemRepository.Delete(OrderItem);
	}
}