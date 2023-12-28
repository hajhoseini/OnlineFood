using OnlineFood.Domain.Entities.Messages;
using OnlineFood.Domain.InterfaceRepositories.Messages;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Messages;

public class MessageRepository : GenericRepository<Message>, IMessageRepository
{
    public MessageRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}