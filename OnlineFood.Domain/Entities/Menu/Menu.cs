using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Menu
{
    public class Menu : BaseEntity
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public int MenuCategoryId {  get; set; }
    }
}
