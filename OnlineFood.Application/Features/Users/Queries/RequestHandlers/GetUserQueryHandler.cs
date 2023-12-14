using MediatR;
using OnlineFood.Application.Features.Users.Queries.Requests;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.IReaders.Users;

namespace OnlineFood.Application.Features.Users.Queries.RequestHandlers;

public class GetUserQueryHandler : IRequestHandler<GetUserQuery, User>
{
	private readonly IUserReader _userReader;

	public GetUserQueryHandler(IUserReader userReader)
	{
		this._userReader = userReader;
	}

	public async Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
	{
		return await _userReader.GetById(request.Id);
	}
}
