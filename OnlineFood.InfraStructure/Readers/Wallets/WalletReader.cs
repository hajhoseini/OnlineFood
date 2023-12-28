using OnlineFood.Domain.Entities.Wallets;
using OnlineFood.Domain.IReaders.Wallets;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Wallets;

public class WalletReader : GenericReader<Wallet>, IWalletReader
{
    public WalletReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}