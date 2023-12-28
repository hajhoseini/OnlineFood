using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Wallets.Commands.Requests;
using OnlineFood.Domain.Entities.Wallets;
using OnlineFood.Domain.InterfaceRepositories.Wallets;

namespace OnlineFood.Application.Features.Wallets.Commands.RequestHandlers;

public class UpdateWalletCommandHandler : IRequestHandler<UpdateWalletCommand, bool>
{
	private readonly IWalletRepository _WalletRepository;
	private readonly IMapper _mapper;

	public UpdateWalletCommandHandler(IWalletRepository walletRepository, IMapper mapper)
	{
		this._WalletRepository = walletRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateWalletCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Wallet>(request);
		return _WalletRepository.Update(entity);
	}
}