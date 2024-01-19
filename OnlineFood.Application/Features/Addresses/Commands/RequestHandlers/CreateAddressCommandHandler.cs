using AutoMapper;
using MediatR;
using OnlineFood.Domain.IRepositories;
using OnlineFood.Application.Features.Addresses.Commands.Requests;
using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.InterfaceRepositories.Addresses;

namespace OnlineFood.Application.Features.Addresses.Commands.RequestHandlers;

public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, int>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IAddressRepository _addressRepository;
    public CreateAddressCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IAddressRepository addressRepository)
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
        _addressRepository = addressRepository;
    }

    public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Address>(request);
        var result =await _addressRepository.AddressCreate(entity);
        return result;
    }
}