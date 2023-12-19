using MediatR;
using OnlineFood.Application.Features.OrderItems.Queries.Requests;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.IReaders.OrderItems;

namespace OnlineFood.Application.Features.OrderItems.Queries.RequestHandlers;

public class GetListOrderItemsQueryHandler : IRequestHandler<GetListOrderItemsQuery, List<OrderItem>>
{
	private readonly IOrderItemReader _OrderItemReader;

	public GetListOrderItemsQueryHandler(IOrderItemReader OrderItemReader)
	{
		this._OrderItemReader = OrderItemReader;
	}

	public async Task<List<OrderItem>> Handle(GetListOrderItemsQuery request, CancellationToken cancellationToken)
	{
		var all = await _OrderItemReader.GetList(null, null);
		return all.ToList();
	}
}
