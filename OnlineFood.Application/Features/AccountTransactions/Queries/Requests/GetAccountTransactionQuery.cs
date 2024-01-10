using MediatR;
using OnlineFood.Domain.Entities.AccountTransactions;

namespace OnlineFood.Application.Features.AccountTransactions.Queries.Requests;

public class GetAccountTransactionQuery : IRequest<AccountTransaction>
{
	public int Id { get; set; }
}
