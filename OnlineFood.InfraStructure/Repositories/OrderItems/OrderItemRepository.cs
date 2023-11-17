using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.InterfaceRepositories.OrderItems;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.OrderItems;

public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
{
    public OrderItemRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}