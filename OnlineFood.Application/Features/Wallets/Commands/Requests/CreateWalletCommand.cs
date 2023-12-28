using MediatR;

namespace OnlineFood.Application.Features.Wallets.Commands.Requests;

public class CreateWalletCommand : IRequest<bool>
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public decimal Amount { get; set; }
}