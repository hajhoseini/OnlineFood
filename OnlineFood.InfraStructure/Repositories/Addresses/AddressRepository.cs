using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.InterfaceRepositories.Addresses;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Addresses;

public class AddressRepository : GenericRepository<Address>, IAddressRepository
{
    private readonly OnlineFoodDBConext _dbContext;
    public AddressRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> AddressCreate(Address address)
    {
       var result=  _dbContext.Address.Add(address);
       _dbContext.SaveChangesAsync();
       return result.Entity.Id;
    }
}