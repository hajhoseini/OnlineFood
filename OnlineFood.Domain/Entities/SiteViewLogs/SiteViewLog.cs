using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.SiteViewLogs;

public class SiteViewLog : BaseEntity
{
    public string IP { get; set; }
    public string Browser { get; set; }
}
