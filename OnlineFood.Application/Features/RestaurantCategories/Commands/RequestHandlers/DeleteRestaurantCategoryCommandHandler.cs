using MediatR;
using OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.InterfaceRepositories.RestaurantCategories;

namespace OnlineFood.Application.Features.RestaurantCategories.Commands.RequestHandlers;

public class DeleteRestaurantCategoryCommandHandler : IRequestHandler<DeleteRestaurantCategoryCommand, bool>
{
	private readonly IRestaurantCategoryRepository _RestaurantCategoryRepository;

	public DeleteRestaurantCategoryCommandHandler(IRestaurantCategoryRepository RestaurantCategoryRepository)
	{
		this._RestaurantCategoryRepository = RestaurantCategoryRepository;
	}

	public Task<bool> Handle(DeleteRestaurantCategoryCommand request, CancellationToken cancellationToken)
	{
        RestaurantCategory RestaurantCategory = new RestaurantCategory { Id = request.Id };
		return _RestaurantCategoryRepository.Delete(RestaurantCategory);
	}
}