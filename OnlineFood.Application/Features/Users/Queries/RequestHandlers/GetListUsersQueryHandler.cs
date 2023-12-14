using MediatR;
using OnlineFood.Application.Features.Users.Queries.Requests;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.IReaders.Users;

namespace OnlineFood.Application.Features.Users.Queries.RequestHandlers;

public class GetListUsersQueryHandler : IRequestHandler<GetListUsersQuery, List<User>>
{
	private readonly IUserReader _userReader;

	public GetListUsersQueryHandler(IUserReader userReader)
	{
		this._userReader = userReader;
	}

	public async Task<List<User>> Handle(GetListUsersQuery request, CancellationToken cancellationToken)
	{
		var all = await _userReader.GetList(null, null);
		return all.ToList();
	}
}
