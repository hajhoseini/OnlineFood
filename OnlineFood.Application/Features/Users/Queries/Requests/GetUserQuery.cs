using MediatR;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Features.Users.Queries.Requests;

public class GetUserQuery : IRequest<User>
{
	public int Id { get; set; }
}
