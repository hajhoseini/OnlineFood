using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.IRepositories.UserAdderss;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.UserAdderss;

public class UserAdderssRepository:GenericRepository<UsersAddresses>,IUserAdderssRepository
{
    public UserAdderssRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}