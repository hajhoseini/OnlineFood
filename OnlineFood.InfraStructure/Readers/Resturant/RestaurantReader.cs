using OnlineFood.Domain.Entities.Resturants;
using OnlineFood.Domain.IReaders.Restaurants;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Resturant;

public class RestaurantReader:GenericReader<Restaurant>,IRestaurantReader
{
    public RestaurantReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}