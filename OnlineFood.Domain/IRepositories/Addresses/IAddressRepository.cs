using OnlineFood.Domain.Entities.Addresses;

namespace OnlineFood.Domain.InterfaceRepositories.Addresses;

public interface IAddressRepository : IGenericRepository<Address>
{
 Task<int> AddressCreate(Address address);
}