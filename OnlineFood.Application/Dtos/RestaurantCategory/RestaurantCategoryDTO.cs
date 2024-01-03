using OnlineFood.Common.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineFood.Application.Dtos.Message;

public class RestaurantCategoryDTO
{
    [Required]
    [DisplayName("عنوان")]
    public string Title { get; set; }

    [Required]
    [DisplayName("توضیحات")]
    public string Description { get; set; }
}