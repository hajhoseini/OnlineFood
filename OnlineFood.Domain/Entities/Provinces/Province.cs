using OnlineFood.Domain.Entities.Base;
using OnlineFood.Domain.Entities.Cities;
using System.ComponentModel.DataAnnotations;

namespace OnlineFood.Domain.Entities.Provinces;

public class Province : BaseEntity
{
    [Required]
    public string Name { get; set; }

    public ICollection<City> City { get; } = new List<City>();
}