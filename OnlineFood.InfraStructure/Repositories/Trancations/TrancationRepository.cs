using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.InterfaceRepositories.Trancations;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Trancations;

public class TrancationRepository : GenericRepository<Trancation>, ITrancationRepository
{
	public TrancationRepository(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}