using OnlineFood.Common.Enums;
using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Messages;

public class Message : BaseEntity
{
    public string Title { get; set; }
    public string Text { get; set; }
    public SendTypeEnum SendType { get; set; }
}