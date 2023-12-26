using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Addresses.Commands.Requests;
using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.InterfaceRepositories.Addresses;

namespace OnlineFood.Application.Features.Addresses.Commands.RequestHandlers;

public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommand, bool>
{
	private readonly IAddressRepository _AddressRepository;
	private readonly IMapper _mapper;

	public UpdateAddressCommandHandler(IAddressRepository addressRepository, IMapper mapper)
	{
		this._AddressRepository = addressRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Address>(request);
		return _AddressRepository.Update(entity);
	}
}