using MediatR;
using OnlineFood.Application.Features.Orders.Queries.Requests;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.IReaders.Orders;

namespace OnlineFood.Application.Features.Orders.Queries.RequestHandlers;

public class GetListOrdersQueryHandler : IRequestHandler<GetListOrdersQuery, List<Order>>
{
	private readonly IOrderReader _OrderReader;

	public GetListOrdersQueryHandler(IOrderReader OrderReader)
	{
		this._OrderReader = OrderReader;
	}

	public async Task<List<Order>> Handle(GetListOrdersQuery request, CancellationToken cancellationToken)
	{
		var all = await _OrderReader.GetList(null, null);
		return all.ToList();
	}
}
