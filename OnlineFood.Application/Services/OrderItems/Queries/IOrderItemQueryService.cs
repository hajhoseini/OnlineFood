using OnlineFood.Domain.Entities.OrderItems;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.OrderItems.Queries;

public interface IOrderItemQueryService
{
    Task<OrderItem> GetById(int id);
    Task<List<OrderItem>> GetList(Expression<Func<OrderItem, bool>>? whereVariable = null, string join = "");
}
