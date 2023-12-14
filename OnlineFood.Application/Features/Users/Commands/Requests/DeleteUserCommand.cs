using MediatR;

namespace OnlineFood.Application.Features.Users.Commands.Requests;

public class DeleteUserCommand : IRequest<bool>
{
	public int Id { get; set; }
}
