using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.InterfaceRepositories.Addresses;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Addresses;

public class AddressRepository : GenericRepository<Address>, IAddressRepository
{
    public AddressRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}