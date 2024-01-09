using OnlineFood.Domain.Entities.Transactions;
using OnlineFood.Domain.IReaders.Transactions;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Transactions;

public class TransactionReader : GenericReader<Transaction>, ITransactionReader
{
	public TransactionReader(OnlineFoodDBConext dbContext) : base(dbContext)
	{
	}
}