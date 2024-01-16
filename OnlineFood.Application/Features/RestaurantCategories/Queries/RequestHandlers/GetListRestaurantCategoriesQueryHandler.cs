using MediatR;
using OnlineFood.Application.Dtos.RestaurantCategory;
using OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.IReaders.RestaurantCategories;

namespace OnlineFood.Application.Features.RestaurantCategories.Queries.RequestHandlers;

public class ListRestaurantCategoriesQueryHandler : IRequestHandler<ListRestaurantCategoriesQuery, List<RestaurantCategoryDTO>>
{
	private readonly IRestaurantCategoryReader _RestaurantCategoryReader;

	public ListRestaurantCategoriesQueryHandler(IRestaurantCategoryReader RestaurantCategoryReader)
	{
		this._RestaurantCategoryReader = RestaurantCategoryReader;
	}

    //public async Task<List<RestaurantCategory>> Handle(GetListRestaurantCategoriesQuery request, CancellationToken cancellationToken)
    //{
    //	var all = await _RestaurantCategoryReader.GetList(null, null);
    //	return all.ToList();
    //}
    public async Task<List<RestaurantCategoryDTO>> Handle(ListRestaurantCategoriesQuery request, CancellationToken cancellationToken)
    {
        var allCategories = await _RestaurantCategoryReader.GetList(null);
        return allCategories.Select(category => new RestaurantCategoryDTO
        {
            Title = category.Title,
            Description = category.Description,
            Id = category.Id
        }).ToList();
    }
}
