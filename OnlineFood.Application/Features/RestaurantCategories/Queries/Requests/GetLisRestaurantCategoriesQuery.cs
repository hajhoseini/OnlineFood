using MediatR;
using OnlineFood.Domain.Entities.RestaurantCategories;
 
namespace OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;

public class GetListRestaurantCategoriesQuery : IRequest<List<RestaurantCategory>>
{
}
