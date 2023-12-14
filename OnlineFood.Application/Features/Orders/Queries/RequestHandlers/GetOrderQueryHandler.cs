using MediatR;
using OnlineFood.Application.Features.Orders.Queries.Requests;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.IReaders.Orders;

namespace OnlineFood.Application.Features.Orders.Queries.RequestHandlers;

public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, Order>
{
	private readonly IOrderReader _OrderReader;

	public GetOrderQueryHandler(IOrderReader OrderReader)
	{
		this._OrderReader = OrderReader;
	}

	public async Task<Order> Handle(GetOrderQuery request, CancellationToken cancellationToken)
	{
		return await _OrderReader.GetById(request.Id);
	}
}
