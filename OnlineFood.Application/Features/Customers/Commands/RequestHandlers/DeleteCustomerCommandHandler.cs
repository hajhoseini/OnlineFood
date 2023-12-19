using MediatR;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.InterfaceRepositories.Customers;

namespace OnlineFood.Application.Features.Customers.Commands.RequestHandlers;

public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, bool>
{
	private readonly ICustomerRepository _CustomerRepository;

	public DeleteCustomerCommandHandler(ICustomerRepository CustomerRepository)
	{
		this._CustomerRepository = CustomerRepository;
	}

	public Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
	{
		Customer Customer = new Customer { Id = request.Id };
		return _CustomerRepository.Delete(Customer);
	}
}