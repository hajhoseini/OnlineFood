using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Wallet
{
    public class Wallet:BaseEntity
    {
        public int UserId {  get; set; }
        public string Amount { get; set; }
    }
}
