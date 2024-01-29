using OnlineFood.Application.DTOs.RestaurantCategory;

namespace OnlineFood.Application.Services.RestaurantCategory.Queries;

public interface IRestaurantCategoryQueryService
{
    Task<List<RestaurantCategoryDTO>> List();

}
