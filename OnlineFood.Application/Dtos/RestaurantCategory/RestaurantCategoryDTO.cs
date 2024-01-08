using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineFood.Application.Dtos.RestaurantCategory;

public class RestaurantCategoryDTO
{
    public int Id { get; set; }

    [DisplayName("تاریخ")]
    public DateTime CreateDate { get; set; }

    [Required]
    [DisplayName("عنوان")]
    public string Title { get; set; }

    [Required]
    [DisplayName("توضیحات")]
    public string Description { get; set; }
}