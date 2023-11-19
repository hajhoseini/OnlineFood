using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.MenuItems;

public class MenuItem : BaseEntity
{
    public string Title { get; set; }
    public string Price { get; set; }
    public string Description { get; set; }
    public int MenuId {  get; set; }
}
