using MediatR;
using OnlineFood.Application.Features.Wallets.Queries.Requests;
using OnlineFood.Domain.Entities.Wallets;
using OnlineFood.Domain.IReaders.Wallets;

namespace OnlineFood.Application.Features.Wallets.Queries.RequestHandlers;

public class GetWalletQueryHandler : IRequestHandler<GetWalletQuery, Wallet>
{
	private readonly IWalletReader _WalletReader;

	public GetWalletQueryHandler(IWalletReader walletReader)
	{
		this._WalletReader = walletReader;
	}

	public async Task<Wallet> Handle(GetWalletQuery request, CancellationToken cancellationToken)
	{
		return await _WalletReader.GetById(request.Id);
	}
}