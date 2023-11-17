using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.InterfaceRepositories.Orders;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Orders;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}