using MediatR;

namespace OnlineFood.Application.Features.Users.Commands.Requests;

public class DeleteUserCommand : IRequest<bool>
{
	public string Id { get; set; }
}
