using MediatR;
using OnlineFood.Domain.Entities.MenuItems;

namespace OnlineFood.Application.Features.MenuItems.Queries.Requests
{
    public class GetMenuItemQuery:IRequest<MenuItem>
    {
        public int Id { get; set; }
    }
}
