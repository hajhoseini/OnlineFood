using MediatR;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.IReaders.Customers;

namespace OnlineFood.Application.Features.Customers.Queries.RequestHandlers;

public class GetListCustomersQueryHandler : IRequestHandler<GetListCustomersQuery, List<Customer>>
{
	private readonly ICustomerReader _CustomerReader;

	public GetListCustomersQueryHandler(ICustomerReader CustomerReader)
	{
		this._CustomerReader = CustomerReader;
	}

	public async Task<List<Customer>> Handle(GetListCustomersQuery request, CancellationToken cancellationToken)
	{
		var all = await _CustomerReader.GetList(null, null);
		return all.ToList();
	}
}
