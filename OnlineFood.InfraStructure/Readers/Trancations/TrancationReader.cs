using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.IReaders.Trancations;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Trancations;

public class TrancationReader : GenericReader<Trancation>, ITrancationReader
{
	public TrancationReader(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}