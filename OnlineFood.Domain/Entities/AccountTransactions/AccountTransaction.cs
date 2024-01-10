using OnlineFood.Common.Enums;
using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.AccountTransactions;

public class AccountTransaction : BaseEntity
{
	public int CustomerId { get; set; }
	public decimal Amount { get; set; }
	public DateTime TrancationDate { get; set; }
	public TransactionstatusEnum Transactionstatus { get; set; }
	public string TrackingCode { get; set; }
}
