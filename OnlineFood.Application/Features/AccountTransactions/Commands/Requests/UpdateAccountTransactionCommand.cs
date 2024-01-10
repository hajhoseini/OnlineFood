using MediatR;
using OnlineFood.Common.Enums;

namespace OnlineFood.Application.Features.AccountTransactions.Commands.Requests;

public class UpdateAccountTransactionCommand : IRequest<bool>
{
	public int Id { get; set; }
	public DateTime CreateDate { get; set; }
	public int CustomerId { get; set; }
	public decimal Amount { get; set; }
	public DateTime TrancationDate { get; set; }
	public TransactionstatusEnum Transactionstatus { get; set; }
	public string TrackingCode { get; set; }
}
