using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.InterfaceRepositories.Customers;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Customers;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}