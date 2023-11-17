using OnlineFood.Application.Dtos.OrderItems;

namespace OnlineFood.Application.Services.OrderItems.Commands;

public interface IOrderItemCommandService
{
    Task<bool> Create(OrderItemDto dto);
    Task<bool> Update(OrderItemDto dto);
    Task<bool> Delete(OrderItemDto dto);
}
