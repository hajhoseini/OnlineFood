using MediatR;
using OnlineFood.Domain.Entities.Favorites;

namespace OnlineFood.Application.Features.Favorites.Queries.Requests;

public class GetListFavoritesQuery : IRequest<List<Favorite>>
{
}
