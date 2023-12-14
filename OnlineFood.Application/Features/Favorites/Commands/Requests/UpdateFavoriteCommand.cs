using MediatR;

namespace OnlineFood.Application.Features.Favorites.Commands.Requests;

public class UpdateFavoriteCommand : IRequest<bool>
{
	public int Id { get; set; }
	public DateTime CreateDate { get; set; }
	public int CustomerId { get; set; }
	public int RestaurantId { get; set; }
	public string Note { get; set; }
}
