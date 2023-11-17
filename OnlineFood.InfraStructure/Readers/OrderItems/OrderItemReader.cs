using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.IReaders.OrderItems;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.OrderItems;

public class OrderItemReader : GenericReader<OrderItem>, IOrderItemReader
{
    public OrderItemReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}