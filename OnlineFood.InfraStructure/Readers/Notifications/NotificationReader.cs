using OnlineFood.Domain.Entities.Notifications;
using OnlineFood.Domain.IReaders.Notifications;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Notifications;

public class NotificationReader : GenericReader<Notification>, INotificationReader
{
    public NotificationReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}