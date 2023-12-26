using OnlineFood.Domain.Entities.Wallets;
using OnlineFood.Domain.InterfaceRepositories.Wallets;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Wallets;

public class WalletRepository : GenericRepository<Wallet>, IWalletRepository
{
    public WalletRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}