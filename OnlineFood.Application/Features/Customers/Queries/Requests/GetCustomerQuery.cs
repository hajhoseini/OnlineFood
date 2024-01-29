using MediatR;
using OnlineFood.Application.DTOs.Customers;

namespace OnlineFood.Application.Features.Customers.Queries.Requests;

public class GetCustomerQuery : IRequest<CustomerDTO>
{
	public int Id { get; set; }
}
