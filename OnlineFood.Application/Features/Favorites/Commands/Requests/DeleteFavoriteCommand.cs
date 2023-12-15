using MediatR;

namespace OnlineFood.Application.Features.Favorites.Commands.Requests;

public class DeleteFavoriteCommand : IRequest<bool>
{
	public int Id { get; set; }
}
