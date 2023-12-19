using MediatR;
using OnlineFood.Domain.Entities.Customers;

namespace OnlineFood.Application.Features.Customers.Queries.Requests;

public class GetListCustomersQuery : IRequest<List<Customer>>
{
}
