using MediatR;

namespace OnlineFood.Application.Features.Addresses.Commands.Requests;

public class DeleteAddressCommand : IRequest<bool>
{
	public int Id { get; set; }
}