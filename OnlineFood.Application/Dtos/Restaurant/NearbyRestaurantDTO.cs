using System.ComponentModel;

namespace OnlineFood.Application.DTOs.Restaurant;

public class NearbyRestaurantDTO
{
    [DisplayName("نام رستوران")]
    public string Name { get; set; }

    public double Distance { get; set; }
}
