using AutoMapper;
using MediatR;
using OnlineFood.Domain.IRepositories;
using OnlineFood.Application.Features.Wallets.Commands.Requests;
using OnlineFood.Domain.Entities.Wallets;

namespace OnlineFood.Application.Features.Wallets.Commands.RequestHandlers;

public class CreateWalletCommandHandler:IRequestHandler<CreateWalletCommand,bool>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateWalletCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateWalletCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Wallet>(request);
        var result = await _unitOfWork.GenericReposity<Wallet>().Create(entity);
        return result;
    }
}