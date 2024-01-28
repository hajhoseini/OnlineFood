namespace OnlineFood.Application.DTOs.Favorites;

public class FavoriteDTO
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int RestaurantId { get; set; }
    public string Note { get; set; }
}
