using MediatR;
using OnlineFood.Domain.Entities.Resturants;

namespace OnlineFood.Application.Features.Restaurants.Queries.Requests
{
    public class GetRestaurantQuery:IRequest<Restaurant>
    {
        public int Id {  get; set; }
    }
}
