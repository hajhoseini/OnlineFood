using MediatR;

namespace OnlineFood.Application.Features.Wallets.Commands.Requests;

public class DeleteWalletCommand : IRequest<bool>
{
	public int Id { get; set; }
}