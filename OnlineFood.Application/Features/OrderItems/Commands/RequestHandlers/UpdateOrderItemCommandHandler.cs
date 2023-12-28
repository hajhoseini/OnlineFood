using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.OrderItems.Commands.Requests;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.InterfaceRepositories.OrderItems;

namespace OnlineFood.Application.Features.OrderItems.Commands.RequestHandlers;

public class UpdateOrderItemCommandHandler : IRequestHandler<UpdateOrderItemCommand, bool>
{
    private readonly IOrderItemRepository _orderItemRpository;
    private readonly IMapper _mapper;

    public UpdateOrderItemCommandHandler(IOrderItemRepository orderItemRpository, IMapper mapper)
    {
        this._orderItemRpository = orderItemRpository;
        this._mapper = mapper;
    }

    public Task<bool> Handle(UpdateOrderItemCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<OrderItem>(request);
        return _orderItemRpository.Update(entity);
    }
}
