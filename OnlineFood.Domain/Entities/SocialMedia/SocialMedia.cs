using OnlineFood.Common.Enums;
using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.SocialMedia
{
    public class SocialMedia :BaseEntity
    {
        public SocialmediaEnum Name { get; set; }
        public string Url { get; set; }
    }
}
