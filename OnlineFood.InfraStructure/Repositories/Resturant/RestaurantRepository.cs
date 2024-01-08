using OnlineFood.Domain.Entities.Resturants;
using OnlineFood.Domain.IRepositories.Restaurants;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Resturant;

public class RestaurantRepository:GenericRepository<Restaurant>,IRestaurantRepository
{
    public RestaurantRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}