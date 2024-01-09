using MediatR;
using OnlineFood.Domain.Entities.Transactions;

namespace OnlineFood.Application.Features.Transactions.Queries.Requests;

public class GetTransactionQuery : IRequest<Transaction>
{
	public int Id { get; set; }
}
