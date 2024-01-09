using OnlineFood.Domain.Entities.Transactions;
using OnlineFood.Domain.InterfaceRepositories.Transactions;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Transactions;

public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
{
	public TransactionRepository(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}