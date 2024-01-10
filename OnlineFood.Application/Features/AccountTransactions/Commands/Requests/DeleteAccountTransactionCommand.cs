using MediatR;

namespace OnlineFood.Application.Features.AccountTransactions.Commands.Requests;

public class DeleteAccountTransactionCommand : IRequest<bool>
{
	public int Id { get; set; }
}
