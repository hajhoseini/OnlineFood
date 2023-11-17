using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.IReaders.Orders;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Orders;

public class OrderReader : GenericReader<Order>, IOrderReader
{
    public OrderReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}