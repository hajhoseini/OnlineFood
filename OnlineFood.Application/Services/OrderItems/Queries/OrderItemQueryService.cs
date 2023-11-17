using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.IReaders.OrderItems;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.OrderItems.Queries;

public class OrderItemQueryService : IOrderItemQueryService
{
    private readonly IOrderItemReader _OrderItemReader;

    public OrderItemQueryService(IOrderItemReader OrderItemReader)
    {
        _OrderItemReader = OrderItemReader;
    }

    public async Task<OrderItem> GetById(int id)
    {
        return await _OrderItemReader.GetById(id);
    }

    public async Task<List<OrderItem>> GetList(Expression<Func<OrderItem, bool>>? whereVariable = null, string join = "")
    {
        var all = await _OrderItemReader.GetList();
        return all.ToList();
    }
}
