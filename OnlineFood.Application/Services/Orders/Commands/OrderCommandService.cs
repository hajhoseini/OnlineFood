using AutoMapper;
using OnlineFood.Application.Dtos.Orders;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.InterfaceRepositories.Orders;

namespace OnlineFood.Application.Services.Orders.Commands;

public class OrderCommandService : IOrderCommandService
{
    private readonly IOrderRepository _OrderRepository;
    private readonly IMapper _mapper;

    public OrderCommandService(IOrderRepository OrderRepository, IMapper mapper)
    {
        _OrderRepository = OrderRepository;
        _mapper = mapper;
    }

    public async Task<bool> Create(OrderDto dto)
    {
        var Order = _mapper.Map<Order>(dto);
        return await _OrderRepository.Create(Order);
    }

    public async Task<bool> Delete(OrderDto dto)
    {
        var Order = _mapper.Map<Order>(dto);
        return await _OrderRepository.Delete(Order);
    }

    public async Task<bool> Update(OrderDto dto)
    {
        var Order = _mapper.Map<Order>(dto);
        return await _OrderRepository.Update(Order);
    }
}
