using MediatR;

namespace OnlineFood.Application.Features.Transactions.Commands.Requests;

public class DeleteTransactionCommand : IRequest<bool>
{
	public int Id { get; set; }
}
