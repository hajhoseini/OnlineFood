using MediatR;
using OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.IReaders.RestaurantCategories;

namespace OnlineFood.Application.Features.RestaurantCategories.Queries.RequestHandlers;

public class GetListRestaurantCategoriesQueryHandler : IRequestHandler<GetListRestaurantCategoriesQuery, List<RestaurantCategory>>
{
	private readonly IRestaurantCategoryReader _RestaurantCategoryReader;

	public GetListRestaurantCategoriesQueryHandler(IRestaurantCategoryReader RestaurantCategoryReader)
	{
		this._RestaurantCategoryReader = RestaurantCategoryReader;
	}

	public async Task<List<RestaurantCategory>> Handle(GetListRestaurantCategoriesQuery request, CancellationToken cancellationToken)
	{
		var all = await _RestaurantCategoryReader.GetList(null, null);
		return all.ToList();
	}
}
