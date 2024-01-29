using System.ComponentModel;

namespace OnlineFood.Application.DTOs.Restaurant;

public class PopularRestaurantDTO
{
    [DisplayName("نام رستوران")]
    public string Name { get; set; }

    [DisplayName("رتبه محبوبیت")]
    public int PopularityRank { get; set; }
}
