using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.RestaurantCategories;

public class RestaurantCategory : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
}