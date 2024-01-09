using MediatR;
using OnlineFood.Application.Features.Transactions.Queries.Requests;
using OnlineFood.Domain.Entities.Transactions;
using OnlineFood.Domain.IReaders.Transactions;

namespace OnlineFood.Application.Features.Transactions.Queries.RequestHandlers;

public class GetTransactionQueryHandler : IRequestHandler<GetTransactionQuery, Transaction>
{
	private readonly ITransactionReader _TransactionReader;

	public GetTransactionQueryHandler(ITransactionReader TransactionReader)
	{
		_TransactionReader = TransactionReader;
	}

	public async Task<Transaction> Handle(GetTransactionQuery request, CancellationToken cancellationToken)
	{
		return await _TransactionReader.GetById(request.Id);
	}
}
