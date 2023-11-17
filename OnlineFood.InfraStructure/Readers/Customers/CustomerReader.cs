using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.IReaders.Customers;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Customers;

public class CustomerReader : GenericReader<Customer>, ICustomerReader
{
    public CustomerReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}