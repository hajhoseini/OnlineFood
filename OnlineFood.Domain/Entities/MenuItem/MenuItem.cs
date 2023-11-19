
using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.MenuItem
{
    internal class MenuItem : BaseEntity
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int MenuId {  get; set; }
    }
}
