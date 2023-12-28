using MediatR;
using OnlineFood.Application.Features.Restaurants.Queries.Requests;
using OnlineFood.Domain.Entities.Resturants;
using OnlineFood.Domain.IReaders.Restaurants;

namespace OnlineFood.Application.Features.Restaurants.Queries.RequestHandlers
{
    public class GetRestaurantQueryHandler:IRequestHandler<GetRestaurantQuery,Restaurant>
    {
        private readonly IRestaurantReader reader;
        public GetRestaurantQueryHandler(IRestaurantReader reader)
        {
            this.reader = reader;
        }
        public async Task<Restaurant> Handle(GetRestaurantQuery request, CancellationToken cancellationToken)
        {
            return await reader.GetById(request.Id);
        }
    }
}
