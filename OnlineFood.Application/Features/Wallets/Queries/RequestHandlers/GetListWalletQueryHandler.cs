using MediatR;
using OnlineFood.Application.Features.Wallets.Queries.Requests;
using OnlineFood.Domain.Entities.Wallets;
using OnlineFood.Domain.IReaders.Wallets;

namespace OnlineFood.Application.Features.Wallets.Queries.RequestHandlers;

public class GetListWalletsQueryHandler : IRequestHandler<GetListWalletsQuery, List<Wallet>>
{
	private readonly IWalletReader _WalletReader;

	public GetListWalletsQueryHandler(IWalletReader walletReader)
	{
		this._WalletReader = walletReader;
	}

	public async Task<List<Wallet>> Handle(GetListWalletsQuery request, CancellationToken cancellationToken)
	{
		var all = await _WalletReader.GetList(null, null);
		return all.ToList();
	}
}