using MediatR;
using OnlineFood.Application.DTOs.RestaurantCategory;
using OnlineFood.Domain.Entities.RestaurantCategories;
 
namespace OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;

public class GetListRestaurantCategoriesQuery : IRequest<List<RestaurantCategoryDTO>>
{
}
