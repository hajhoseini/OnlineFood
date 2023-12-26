using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Favorites.Commands.Requests;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Favorites.Commands.RequestHandlers;

public class CreateFavoriteCommandHandler : IRequestHandler<CreateFavoriteCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateFavoriteCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateFavoriteCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Favorite>(request);
		var result = await _unitOfWork.GenericReposity<Favorite>().Create(entity);
		return result;
	}
}
