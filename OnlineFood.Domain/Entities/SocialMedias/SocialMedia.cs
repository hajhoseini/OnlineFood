using OnlineFood.Common.Enums;
using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.SocialMedias;

public class SocialMedia : BaseEntity
{
    public int RestaurantId { get; set; }
    public SocialMediaTypeEnum SocialMediaType { get; set; }
    public string Url { get; set; }
}
