using OnlineFood.Application.DTOs.Restaurant;

namespace OnlineFood.Application.Services.Restaurant.Queries;

public interface IRestaurantQueryService
{
    Task<List<NewestRestaurantDTO>> NewestList();
    Task<List<PopularRestaurantDTO>> PopularList();
    Task<List<NearbyRestaurantDTO>> NearbyList();
    Task<List<DiscountedRestaurantDTO>> DiscountedList();
}
