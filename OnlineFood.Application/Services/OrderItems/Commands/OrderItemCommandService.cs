using AutoMapper;
using OnlineFood.Application.Dtos.OrderItems;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.InterfaceRepositories.OrderItems;

namespace OnlineFood.Application.Services.OrderItems.Commands;

public class OrderItemCommandService : IOrderItemCommandService
{
    private readonly IOrderItemRepository _OrderItemRepository;
    private readonly IMapper _mapper;

    public OrderItemCommandService(IOrderItemRepository OrderItemRepository, IMapper mapper)
    {
        _OrderItemRepository = OrderItemRepository;
        _mapper = mapper;
    }

    public async Task<bool> Create(OrderItemDto dto)
    {
        var OrderItem = _mapper.Map<OrderItem>(dto);
        return await _OrderItemRepository.Create(OrderItem);
    }

    public async Task<bool> Delete(OrderItemDto dto)
    {
        var OrderItem = _mapper.Map<OrderItem>(dto);
        return await _OrderItemRepository.Delete(OrderItem);
    }

    public async Task<bool> Update(OrderItemDto dto)
    {
        var OrderItem = _mapper.Map<OrderItem>(dto);
        return await _OrderItemRepository.Update(OrderItem);
    }
}
