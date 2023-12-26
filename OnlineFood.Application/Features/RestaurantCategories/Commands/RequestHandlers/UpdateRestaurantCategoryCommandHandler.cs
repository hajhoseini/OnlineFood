using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.InterfaceRepositories.RestaurantCategories;

namespace OnlineFood.Application.Features.RestaurantCategories.Commands.RequestHandlers;

public class UpdateRestaurantCategoryCommandHandler : IRequestHandler<UpdateRestaurantCategoryCommand, bool>
{
	private readonly IRestaurantCategoryRepository _RestaurantCategoryRepository;
	private readonly IMapper _mapper;

	public UpdateRestaurantCategoryCommandHandler(IRestaurantCategoryRepository RestaurantCategoryRepository, IMapper mapper)
	{
		this._RestaurantCategoryRepository = RestaurantCategoryRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateRestaurantCategoryCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<RestaurantCategory>(request);
		return _RestaurantCategoryRepository.Update(entity);
	}
}
