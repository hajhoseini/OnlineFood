using OnlineFood.Domain.Entities.Orders;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Orders.Queries;

public interface IOrderQueryService
{
    Task<Order> GetById(int id);
    Task<List<Order>> GetList(Expression<Func<Order, bool>>? whereVariable = null, string join = "");
}
