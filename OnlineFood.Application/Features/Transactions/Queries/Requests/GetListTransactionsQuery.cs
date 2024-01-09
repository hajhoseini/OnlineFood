using MediatR;
using OnlineFood.Domain.Entities.Transactions;

namespace OnlineFood.Application.Features.Transactions.Queries.Requests;

public class GetListTransactionsQuery : IRequest<List<Transaction>>
{
}
