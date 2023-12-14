using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.InterfaceRepositories.Customers;

namespace OnlineFood.Application.Features.Customers.Commands.RequestHandlers;

public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, bool>
{
	private readonly ICustomerRepository _CustomerRepository;
	private readonly IMapper _mapper;

	public UpdateCustomerCommandHandler(ICustomerRepository CustomerRepository, IMapper mapper)
	{
		this._CustomerRepository = CustomerRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Customer>(request);
		return _CustomerRepository.Update(entity);
	}
}
