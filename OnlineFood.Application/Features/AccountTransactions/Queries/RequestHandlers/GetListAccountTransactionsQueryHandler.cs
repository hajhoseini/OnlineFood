using MediatR;
using OnlineFood.Application.Features.AccountTransactions.Queries.Requests;
using OnlineFood.Domain.Entities.AccountTransactions;
using OnlineFood.Domain.IReaders.AccountTransactions;

namespace OnlineFood.Application.Features.AccountTransactions.Queries.RequestHandlers;

public class GetListAccountTransactionsQueryHandler : IRequestHandler<GetListAccountTransactionsQuery, List<AccountTransaction>>
{
	private readonly IAccountTransactionReader _AccountTransactionReader;

	public GetListAccountTransactionsQueryHandler(IAccountTransactionReader AccountTransactionReader)
	{
		_AccountTransactionReader = AccountTransactionReader;
	}

	public async Task<List<AccountTransaction>> Handle(GetListAccountTransactionsQuery request, CancellationToken cancellationToken)
	{
		var all = await _AccountTransactionReader.GetList(null, null);
		return all.ToList();
	}
}
