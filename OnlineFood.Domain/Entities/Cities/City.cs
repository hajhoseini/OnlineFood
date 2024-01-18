using OnlineFood.Domain.Entities.Base;
using OnlineFood.Domain.Entities.Provinces;
using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Domain.Entities.Cities;

public class City : BaseEntity
{
    [Required]
    public string Name { get; set; }

    [Required]
    public int ProvinceId { get; set; }

    [Required]
    public Province Province { get; set; } = null!;
}