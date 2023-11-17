using OnlineFood.Application.Dtos.Orders;

namespace OnlineFood.Application.Services.Orders.Commands;

public interface IOrderCommandService
{
    Task<bool> Create(OrderDto dto);
    Task<bool> Update(OrderDto dto);
    Task<bool> Delete(OrderDto dto);
}
