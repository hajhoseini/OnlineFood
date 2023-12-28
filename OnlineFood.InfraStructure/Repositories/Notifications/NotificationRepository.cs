using OnlineFood.Domain.Entities.Notifications;
using OnlineFood.Domain.InterfaceRepositories.Notifications;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Notifications;

public class NotificationRepository : GenericRepository<Notification>, INotificationRepository
{
    public NotificationRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}