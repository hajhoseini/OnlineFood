using MediatR;
using OnlineFood.Common.Enums;

namespace OnlineFood.Application.Features.Trancations.Commands.Requests;

public class UpdateTrancationCommand : IRequest<bool>
{
	public int Id { get; set; }
	public DateTime CreateDate { get; set; }
	public int CustomerId { get; set; }
	public decimal Amount { get; set; }
	public DateTime TrancationDate { get; set; }
	public TrancationStatusEnum TrancationStatus { get; set; }
	public string TrackingCode { get; set; }
}
