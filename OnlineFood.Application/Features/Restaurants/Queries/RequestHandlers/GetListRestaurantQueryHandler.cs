using MediatR;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.Application.Features.Restaurants.Queries.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.Resturants;
using OnlineFood.Domain.IReaders.Customers;
using OnlineFood.Domain.IReaders.Restaurants;

namespace OnlineFood.Application.Features.Restaurants.Queries.RequestHandlers
{
    public class GetListRestaurantQueryHandler:IRequestHandler<GetListRestaurantQuery,List<Restaurant>>
    {
        private readonly IRestaurantReader reader;

        public GetListRestaurantQueryHandler(IRestaurantReader reader)
        {
            this.reader = reader;
        }

        public async Task<List<Restaurant>> Handle(GetListRestaurantQuery request, CancellationToken cancellationToken)
        {
            var all = await reader.GetList(null, null);
            return all.ToList();
        }
    }
}
