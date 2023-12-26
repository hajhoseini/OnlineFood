using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.IReaders.RestaurantCategories;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Orders;

public class RestaurantCategoryReader : GenericReader<RestaurantCategory>, IRestaurantCategoryReader
{
    public RestaurantCategoryReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}