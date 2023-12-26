using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Customers.Commands.RequestHandlers;

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateCustomerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Customer>(request);
		var result = await _unitOfWork.GenericReposity<Customer>().Create(entity);
		return result;
	}
}
