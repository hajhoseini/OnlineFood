using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.OrderItems.Commands.Requests;
using OnlineFood.Domain.Entities.OrderItems;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.OrderItems.Commands.RequestHandlers;

public class CreateOrderItemCommandHandler : IRequestHandler<CreateOrderItemCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateOrderItemCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<OrderItem>(request);
		var result = await _unitOfWork.GenericReposity<OrderItem>().Create(entity);
		return result;
	}
}
