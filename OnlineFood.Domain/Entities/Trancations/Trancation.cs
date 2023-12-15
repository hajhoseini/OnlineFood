using OnlineFood.Common.Enums;
using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.Trancations;

public class Trancation : BaseEntity
{
	public int CustomerId { get; set; }
	public decimal Amount { get; set; }
	public DateTime TrancationDate { get; set; }
	public TrancationStatusEnum TrancationStatus { get; set; }
	public string TrackingCode { get; set; }
}
