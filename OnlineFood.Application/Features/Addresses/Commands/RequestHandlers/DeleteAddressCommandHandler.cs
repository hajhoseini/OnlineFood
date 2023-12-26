using MediatR;
using OnlineFood.Application.Features.Addresses.Commands.Requests;
using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.InterfaceRepositories.Addresses;

namespace OnlineFood.Application.Features.Addresses.Commands.RequestHandlers;

public class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand, bool>
{
	private readonly IAddressRepository _AddressRepository;

	public DeleteAddressCommandHandler(IAddressRepository addressRepository)
	{
		this._AddressRepository = addressRepository;
	}

	public Task<bool> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
	{
		var Address = new Address { Id = request.Id };
		return _AddressRepository.Delete(Address);
	}
}