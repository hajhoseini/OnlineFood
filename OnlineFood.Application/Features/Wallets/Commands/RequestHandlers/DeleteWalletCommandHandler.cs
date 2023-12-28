using MediatR;
using OnlineFood.Application.Features.Wallets.Commands.Requests;
using OnlineFood.Domain.Entities.Wallets;
using OnlineFood.Domain.InterfaceRepositories.Wallets;

namespace OnlineFood.Application.Features.Wallets.Commands.RequestHandlers;

public class DeleteWalletCommandHandler : IRequestHandler<DeleteWalletCommand, bool>
{
	private readonly IWalletRepository _WalletRepository;

	public DeleteWalletCommandHandler(IWalletRepository walletRepository)
	{
		this._WalletRepository = walletRepository;
	}

	public Task<bool> Handle(DeleteWalletCommand request, CancellationToken cancellationToken)
	{
		var Wallet = new Wallet { Id = request.Id };
		return _WalletRepository.Delete(Wallet);
	}
}