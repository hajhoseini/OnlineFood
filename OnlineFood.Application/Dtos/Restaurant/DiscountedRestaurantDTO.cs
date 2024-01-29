using System.ComponentModel;

namespace OnlineFood.Application.DTOs.Restaurant;

public class DiscountedRestaurantDTO
{
    [DisplayName("نام رستوران")]
    public string Name { get; set; }

    [DisplayName("درصد تخفیف")]
    public decimal DiscountPercentage { get; set; }
}
