using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Wallets;

public class Wallet:BaseEntity
{
    public int UserId {  get; set; }
    public decimal Amount { get; set; }
}
