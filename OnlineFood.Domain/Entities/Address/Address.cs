using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Address
{
    public class Address:BaseEntity
    {
        public string Neighborhood { get; set; }
        public string Coordinate {  get; set; }
    }
}
