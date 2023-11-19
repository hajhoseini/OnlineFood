using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Notifaction;

public class Notifaction : BaseEntity
{
    public string Title { get; set; }
    public string Text { get; set; }
    public string Period { get; set; }
    public string Order { get; set; }
}

