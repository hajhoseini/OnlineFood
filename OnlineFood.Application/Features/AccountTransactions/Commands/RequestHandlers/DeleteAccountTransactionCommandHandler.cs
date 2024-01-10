using MediatR;
using OnlineFood.Application.Features.AccountTransactions.Commands.Requests;
using OnlineFood.Domain.Entities.AccountTransactions;
using OnlineFood.Domain.InterfaceRepositories.AccountTransactions;

namespace OnlineFood.Application.Features.AccountTransactions.Commands.RequestHandlers;

public class DeleteAccountTransactionCommandHandler : IRequestHandler<DeleteAccountTransactionCommand, bool>
{
	private readonly IAccountTransactionRepository _TransactionRepository;	

	public DeleteAccountTransactionCommandHandler(IAccountTransactionRepository TransactionRepository)
	{
		_TransactionRepository = TransactionRepository;
	}

	public Task<bool> Handle(DeleteAccountTransactionCommand request, CancellationToken cancellationToken)
	{
        AccountTransaction Transaction = new AccountTransaction { Id = request.Id };
		return _TransactionRepository.Delete(Transaction);
	}
}
