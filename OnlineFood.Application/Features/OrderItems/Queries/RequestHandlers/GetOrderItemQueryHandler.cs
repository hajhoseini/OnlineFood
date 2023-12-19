using MediatR;
using OnlineFood.Application.Features.OrderItems.Queries.Requests;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.IReaders.OrderItems;

namespace OnlineFood.Application.Features.OrderItems.Queries.RequestHandlers;

public class GetOrderItemQueryHandler : IRequestHandler<GetOrderItemQuery, OrderItem>
{
	private readonly IOrderItemReader _OrderItemReader;

	public GetOrderItemQueryHandler(IOrderItemReader OrderItemReader)
	{
		this._OrderItemReader = OrderItemReader;
	}

	public async Task<OrderItem> Handle(GetOrderItemQuery request, CancellationToken cancellationToken)
	{
		return await _OrderItemReader.GetById(request.Id);
	}
}
