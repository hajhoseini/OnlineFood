using MediatR;
using OnlineFood.Application.Features.AccountTransactions.Queries.Requests;
using OnlineFood.Domain.Entities.AccountTransactions;
using OnlineFood.Domain.IReaders.AccountTransactions;

namespace OnlineFood.Application.Features.AccountTransactions.Queries.RequestHandlers;

public class GetAccountTransactionQueryHandler : IRequestHandler<GetAccountTransactionQuery, AccountTransaction>
{
	private readonly IAccountTransactionReader _TransactionReader;

	public GetAccountTransactionQueryHandler(IAccountTransactionReader TransactionReader)
	{
		_TransactionReader = TransactionReader;
	}

	public async Task<AccountTransaction> Handle(GetAccountTransactionQuery request, CancellationToken cancellationToken)
	{
		return await _TransactionReader.GetById(request.Id);
	}
}
