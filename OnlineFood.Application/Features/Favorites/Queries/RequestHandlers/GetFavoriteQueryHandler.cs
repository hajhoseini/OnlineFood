using MediatR;
using OnlineFood.Application.Features.Favorites.Queries.Requests;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.IReaders.Favorites;

namespace OnlineFood.Application.Features.Favorites.Queries.RequestHandlers;

public class GetFavoriteQueryHandler : IRequestHandler<GetFavoriteQuery, Favorite>
{
	private readonly IFavoriteReader _FavoriteReader;

	public GetFavoriteQueryHandler(IFavoriteReader FavoriteReader)
	{
		this._FavoriteReader = FavoriteReader;
	}

	public async Task<Favorite> Handle(GetFavoriteQuery request, CancellationToken cancellationToken)
	{
		return await _FavoriteReader.GetById(request.Id);
	}
}
