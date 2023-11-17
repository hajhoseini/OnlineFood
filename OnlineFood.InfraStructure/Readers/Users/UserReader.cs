using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.IReaders.Users;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Users;

public class UserReader : GenericReader<User>, IUserReader
{
    public UserReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}