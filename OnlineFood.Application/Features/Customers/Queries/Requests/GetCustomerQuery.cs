using MediatR;
using OnlineFood.Application.Dtos.Customers;

namespace OnlineFood.Application.Features.Customers.Queries.Requests;

public class GetCustomerQuery : IRequest<CustomerDto>
{
	public int Id { get; set; }
}
