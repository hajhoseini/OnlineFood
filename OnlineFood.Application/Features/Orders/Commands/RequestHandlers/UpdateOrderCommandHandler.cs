using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Orders.Commands.Requests;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.InterfaceRepositories.Orders;

namespace OnlineFood.Application.Features.Orders.Commands.RequestHandlers;

public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand, bool>
{
	private readonly IOrderRepository _OrderRepository;
	private readonly IMapper _mapper;

	public UpdateOrderCommandHandler(IOrderRepository OrderRepository, IMapper mapper)
	{
		this._OrderRepository = OrderRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Order>(request);
		return _OrderRepository.Update(entity);
	}
}
