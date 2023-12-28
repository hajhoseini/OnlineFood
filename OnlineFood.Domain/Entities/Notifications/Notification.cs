using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Notifications;

public class Notification : BaseEntity
{
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime DisplayStartDate { get; set; }
    public DateTime DisplayEndDate { get; set; }
    public string Order { get; set; }
}