using OnlineFood.Domain.Entities.AccountTransactions;
using OnlineFood.Domain.IReaders.AccountTransactions;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.AccountTransactions;

public class AccountTransactionReader : GenericReader<AccountTransaction>, IAccountTransactionReader
{
	public AccountTransactionReader(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}