using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories.Users;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Users;

public class UserRepository: GenericRepository<User>,IUserRepository
{
    public UserRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}