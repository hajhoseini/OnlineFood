using OnlineFood.Application.Dtos.Province;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Application.Dtos.Cities;

public class CityDTO
{
    public long Id { get; set; }

    [DisplayName("تاریخ")]
    public DateTime CreateDate { get; set; }

    [Required]
    [DisplayName("نام شهر")]
    public string Name { get; set; }

    public long ProvinceId { get; set; }

    public ProvinceDTO Province { get; set; }
}