using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.City;

public class City : BaseEntity
{
    public string Name { get; set; }
    public long ProviceId { get; set; }
}
