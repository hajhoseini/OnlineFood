using OnlineFood.Domain.Entities.Messages;
using OnlineFood.Domain.IReaders.Messages;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Messages;

public class MessageReader : GenericReader<Message>, IMessageReader
{
    public MessageReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}