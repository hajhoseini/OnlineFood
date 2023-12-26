using MediatR;
using OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.IReaders.RestaurantCategories;

namespace OnlineFood.Application.Features.RestaurantCategories.Queries.RequestHandlers;	

public class GetRestaurantCategoryQueryHandler : IRequestHandler<GetRestaurantCategoryQuery, RestaurantCategory>
{
	private readonly IRestaurantCategoryReader _RestaurantCategoryReader;

	public GetRestaurantCategoryQueryHandler(IRestaurantCategoryReader RestaurantCategoryReader)
	{
		this._RestaurantCategoryReader = RestaurantCategoryReader;
	}

	public async Task<RestaurantCategory> Handle(GetRestaurantCategoryQuery request, CancellationToken cancellationToken)
	{
		return await _RestaurantCategoryReader.GetById(request.Id);
	}
}
