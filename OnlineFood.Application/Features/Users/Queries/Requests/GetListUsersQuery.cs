using MediatR;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Features.Users.Queries.Requests;

public class GetListUsersQuery : IRequest<List<User>>
{
}
