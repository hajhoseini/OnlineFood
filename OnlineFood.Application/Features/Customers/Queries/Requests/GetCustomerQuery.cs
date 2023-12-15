using MediatR;
using OnlineFood.Domain.Entities.Customers;

namespace OnlineFood.Application.Features.Customers.Queries.Requests;

public class GetCustomerQuery : IRequest<Customer>
{
	public int Id { get; set; }
}
