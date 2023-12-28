using AutoMapper;
using MediatR;
using OnlineFood.Domain.IRepositories;
using OnlineFood.Application.Features.Addresses.Commands.Requests;
using OnlineFood.Domain.Entities.Addresses;

namespace OnlineFood.Application.Features.Addresses.Commands.RequestHandlers;

public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, bool>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateAddressCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Address>(request);
        var result = await _unitOfWork.GenericReposity<Address>().Create(entity);
        return result;
    }
}