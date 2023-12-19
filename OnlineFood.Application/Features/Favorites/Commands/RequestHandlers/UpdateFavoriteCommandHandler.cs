using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Favorites.Commands.Requests;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.InterfaceRepositories.Favorites;

namespace OnlineFood.Application.Features.Favorites.Commands.RequestHandlers;

public class UpdateFavoriteCommandHandler : IRequestHandler<UpdateFavoriteCommand, bool>
{
	private readonly IFavoriteRepository _FavoriteRepository;
	private readonly IMapper _mapper;

	public UpdateFavoriteCommandHandler(IFavoriteRepository FavoriteRepository, IMapper mapper)
	{
		this._FavoriteRepository = FavoriteRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateFavoriteCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Favorite>(request);
		return _FavoriteRepository.Update(entity);
	}
}
