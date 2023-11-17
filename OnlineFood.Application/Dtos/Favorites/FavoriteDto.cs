namespace OnlineFood.Application.Dtos.Favorites;

public class FavoriteDto
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int RestaurantId { get; set; }
    public string Note { get; set; }
}
