using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Favorites;

public class Favorite : BaseEntity
{
    public int CustomerId { get; set; }
    public int RestaurantId { get; set; }
    public string Note { get; set; }
}
