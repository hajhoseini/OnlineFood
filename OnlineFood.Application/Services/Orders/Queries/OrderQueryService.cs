using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.IReaders.Orders;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Orders.Queries;

public class OrderQueryService : IOrderQueryService
{
    private readonly IOrderReader _OrderReader;

    public OrderQueryService(IOrderReader OrderReader)
    {
        _OrderReader = OrderReader;
    }

    public async Task<Order> GetById(int id)
    {
        return await _OrderReader.GetById(id);
    }

    public async Task<List<Order>> GetList(Expression<Func<Order, bool>>? whereVariable = null, string join = "")
    {
        var all = await _OrderReader.GetList();
        return all.ToList();
    }
}
