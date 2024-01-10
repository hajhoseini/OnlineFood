using OnlineFood.Domain.Entities.AccountTransactions;
using OnlineFood.Domain.InterfaceRepositories.AccountTransactions;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.AccountTransactions;

public class AccountTransactionRepository : GenericRepository<AccountTransaction>, IAccountTransactionRepository
{
	public AccountTransactionRepository(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}