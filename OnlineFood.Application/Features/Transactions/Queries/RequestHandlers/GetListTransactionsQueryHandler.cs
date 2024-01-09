using MediatR;
using OnlineFood.Application.Features.Transactions.Queries.Requests;
using OnlineFood.Domain.Entities.Transactions;
using OnlineFood.Domain.IReaders.Transactions;

namespace OnlineFood.Application.Features.Transactions.Queries.RequestHandlers;

public class GetListTransactionsQueryHandler : IRequestHandler<GetListTransactionsQuery, List<Transaction>>
{
	private readonly ITransactionReader _TransactionReader;

	public GetListTransactionsQueryHandler(ITransactionReader TransactionReader)
	{
		_TransactionReader = TransactionReader;
	}

	public async Task<List<Transaction>> Handle(GetListTransactionsQuery request, CancellationToken cancellationToken)
	{
		var all = await _TransactionReader.GetList(null, null);
		return all.ToList();
	}
}
