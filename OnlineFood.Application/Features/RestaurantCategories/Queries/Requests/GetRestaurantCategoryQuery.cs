using MediatR;
using OnlineFood.Domain.Entities.RestaurantCategories;

namespace OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;

public class GetRestaurantCategoryQuery : IRequest<RestaurantCategory>
{
	public int Id { get; set; }
}
