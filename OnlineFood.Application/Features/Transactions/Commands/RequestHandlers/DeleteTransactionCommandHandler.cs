using MediatR;
using OnlineFood.Application.Features.Transactions.Commands.Requests;
using OnlineFood.Domain.Entities.Transactions;
using OnlineFood.Domain.InterfaceRepositories.Transactions;

namespace OnlineFood.Application.Features.Transactions.Commands.RequestHandlers;

public class DeleteTransactionCommandHandler : IRequestHandler<DeleteTransactionCommand, bool>
{
	private readonly ITransactionRepository _TransactionRepository;	

	public DeleteTransactionCommandHandler(ITransactionRepository TransactionRepository)
	{
		_TransactionRepository = TransactionRepository;
	}

	public Task<bool> Handle(DeleteTransactionCommand request, CancellationToken cancellationToken)
	{
		Transaction Transaction = new Transaction { Id = request.Id };
		return _TransactionRepository.Delete(Transaction);
	}
}
