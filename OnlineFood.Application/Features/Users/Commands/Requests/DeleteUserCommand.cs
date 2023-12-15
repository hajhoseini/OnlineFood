using MediatR;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Features.Users.Commands.Requests;

public class DeleteUserCommand : IRequest<bool>
{
	public int Id { get; set; }
}
