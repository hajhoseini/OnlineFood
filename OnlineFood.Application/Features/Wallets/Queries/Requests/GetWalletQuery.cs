using MediatR;
using OnlineFood.Domain.Entities.Wallets;

namespace OnlineFood.Application.Features.Wallets.Queries.Requests;

public class GetWalletQuery : IRequest<Wallet>
{
	public int Id { get; set; }
}