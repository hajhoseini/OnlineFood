using MediatR;
using OnlineFood.Domain.Entities.Orders;

namespace OnlineFood.Application.Features.Orders.Queries.Requests;

public class GetListOrdersQuery : IRequest<List<Order>>
{
}
