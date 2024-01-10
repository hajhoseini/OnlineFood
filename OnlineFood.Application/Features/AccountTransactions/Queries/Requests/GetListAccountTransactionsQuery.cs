using MediatR;
using OnlineFood.Domain.Entities.AccountTransactions;

namespace OnlineFood.Application.Features.AccountTransactions.Queries.Requests;

public class GetListAccountTransactionsQuery : IRequest<List<AccountTransaction>>
{
}
