using MediatR;
using OnlineFood.Domain.Entities.OrderItems;

namespace OnlineFood.Application.Features.OrderItems.Queries.Requests;

public class GetListOrderItemsQuery : IRequest<List<OrderItem>>
{
}
