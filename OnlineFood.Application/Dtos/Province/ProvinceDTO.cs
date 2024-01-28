
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using OnlineFood.Application.DTOs.Cities;

namespace OnlineFood.Application.DTOs.Province;

public class ProvinceDTO
{
    public long Id { get; set; }

    [DisplayName("تاریخ")]
    public DateTime CreateDate { get; set; }

    [Required]
    [DisplayName("نام استان")]
    public string Name { get; set; }

    public List<CityDTO> City { get; set; }
}
