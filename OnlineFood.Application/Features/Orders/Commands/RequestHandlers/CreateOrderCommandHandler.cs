using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Orders.Commands.Requests;
using OnlineFood.Domain.Entities.Orders;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Orders.Commands.RequestHandlers;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateOrderCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Order>(request);
		var result = await _unitOfWork.GenericReposity<Order>().Update(entity);
		return result;
	}
}
