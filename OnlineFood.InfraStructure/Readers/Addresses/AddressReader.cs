using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.IReaders.Addresses;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Addresses;

public class AddressReader : GenericReader<Address>, IAddressReader
{
    public AddressReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}