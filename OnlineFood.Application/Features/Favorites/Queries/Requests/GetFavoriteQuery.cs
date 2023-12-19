using MediatR;
using OnlineFood.Domain.Entities.Favorites;

namespace OnlineFood.Application.Features.Favorites.Queries.Requests;

public class GetFavoriteQuery : IRequest<Favorite>
{
	public int Id { get; set; }
}
