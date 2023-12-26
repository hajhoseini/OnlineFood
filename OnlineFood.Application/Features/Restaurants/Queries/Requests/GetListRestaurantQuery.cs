using MediatR;
using OnlineFood.Domain.Entities.Resturants;

namespace OnlineFood.Application.Features.Restaurants.Queries.Requests
{
    public class GetListRestaurantQuery:IRequest<List<Restaurant>>
    {
    }
}
