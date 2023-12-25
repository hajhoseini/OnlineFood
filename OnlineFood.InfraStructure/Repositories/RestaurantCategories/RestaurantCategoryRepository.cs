using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.InterfaceRepositories.RestaurantCategories;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.RestaurantCategories;

public class RestaurantCategoryRepository : GenericRepository<RestaurantCategory>, IRestaurantCategoryRepository
{
	public RestaurantCategoryRepository(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}