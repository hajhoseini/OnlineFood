using MediatR;
using OnlineFood.Domain.Entities.Wallets;

namespace OnlineFood.Application.Features.Wallets.Queries.Requests;

public class GetListWalletsQuery : IRequest<List<Wallet>>
{
}