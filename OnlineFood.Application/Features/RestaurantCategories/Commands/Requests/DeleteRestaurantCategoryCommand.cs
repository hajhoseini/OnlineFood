using MediatR;

namespace OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;

public class DeleteRestaurantCategoryCommand : IRequest<bool>
{
	public int Id { get; set; }
}
