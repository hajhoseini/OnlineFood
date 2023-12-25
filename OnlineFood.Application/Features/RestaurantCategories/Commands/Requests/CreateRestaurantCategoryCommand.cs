using MediatR;

namespace OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;

public class CreateRestaurantCategoryCommand : IRequest<bool>
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
