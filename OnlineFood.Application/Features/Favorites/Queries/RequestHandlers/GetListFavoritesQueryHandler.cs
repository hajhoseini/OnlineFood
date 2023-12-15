using MediatR;
using OnlineFood.Application.Features.Favorites.Queries.Requests;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.IReaders.Favorites;

namespace OnlineFood.Application.Features.Favorites.Queries.RequestHandlers;

public class GetListFavoritesQueryHandler : IRequestHandler<GetListFavoritesQuery, List<Favorite>>
{
	private readonly IFavoriteReader _FavoriteReader;

	public GetListFavoritesQueryHandler(IFavoriteReader FavoriteReader)
	{
		this._FavoriteReader = FavoriteReader;
	}

	public async Task<List<Favorite>> Handle(GetListFavoritesQuery request, CancellationToken cancellationToken)
	{
		var all = await _FavoriteReader.GetList(null, null);
		return all.ToList();
	}
}
