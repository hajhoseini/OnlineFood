
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using OnlineFood.Application.Dtos.Cities;

namespace OnlineFood.Application.Dtos.Province;

public class ProvinceDTO
{
    public long Id { get; set; }

    [DisplayName("تاریخ")]
    public DateTime CreateDate { get; set; }

    [Required]
    [DisplayName("نام استان")]
    public string Name { get; set; }

    public List<CityDTO> Cities { get; set; }
}
