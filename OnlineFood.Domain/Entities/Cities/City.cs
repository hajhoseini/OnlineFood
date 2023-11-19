using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Cities;

public class City : BaseEntity
{
    public string Name { get; set; }
    public long ProvinceId { get; set; }
}