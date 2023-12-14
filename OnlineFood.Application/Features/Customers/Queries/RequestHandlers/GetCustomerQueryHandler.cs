using MediatR;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.IReaders.Customers;

namespace OnlineFood.Application.Features.Customers.Queries.RequestHandlers;

public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, Customer>
{
	private readonly ICustomerReader _CustomerReader;

	public GetCustomerQueryHandler(ICustomerReader CustomerReader)
	{
		this._CustomerReader = CustomerReader;
	}

	public async Task<Customer> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
	{
		return await _CustomerReader.GetById(request.Id);
	}
}
