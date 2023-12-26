using OnlineFood.Domain.Entities.Cities;
using OnlineFood.Domain.InterfaceRepositories.Cities;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Cities;

public class CityRepository : GenericRepository<City>, ICityRepository
{
	public CityRepository(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}