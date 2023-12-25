using OnlineFood.Domain.Entities.Provinces;
using OnlineFood.Domain.InterfaceRepositories.Provinces;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Provinces;

public class ProvinceRepository : GenericRepository<Province>, IProvinceRepository
{
	public ProvinceRepository(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}