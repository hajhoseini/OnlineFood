using MediatR;
using OnlineFood.Domain.Entities.MenuItems;
namespace OnlineFood.Application.Features.MenuItems.Queries.Requests
{
    public class GetListMenuItemQuery:IRequest<List<MenuItem>>
    {
    }
}
