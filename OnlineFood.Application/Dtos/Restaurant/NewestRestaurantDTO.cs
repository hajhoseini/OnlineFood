using System.ComponentModel;

namespace OnlineFood.Application.DTOs.Restaurant;

public class NewestRestaurantDTO
{
    [DisplayName("نام رستوران")]
    public string Name { get; set; }

    [DisplayName("تاریخ اضافه شدن رستوران ")]
    public DateTime OpeningDate { get; set; }
}
