using MediatR;
using OnlineFood.Application.Features.Favorites.Commands.Requests;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.InterfaceRepositories.Favorites;

namespace OnlineFood.Application.Features.Favorites.Commands.RequestHandlers;

public class DeleteFavoriteCommandHandler : IRequestHandler<DeleteFavoriteCommand, bool>
{
	private readonly IFavoriteRepository _FavoriteRepository;

	public DeleteFavoriteCommandHandler(IFavoriteRepository FavoriteRepository)
	{
		this._FavoriteRepository = FavoriteRepository;
	}

	public Task<bool> Handle(DeleteFavoriteCommand request, CancellationToken cancellationToken)
	{
		Favorite Favorite = new Favorite { Id = request.Id };
		return _FavoriteRepository.Delete(Favorite);
	}
}