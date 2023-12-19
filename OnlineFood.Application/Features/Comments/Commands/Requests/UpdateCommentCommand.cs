using MediatR;
using OnlineFood.Common.Enums;

namespace OnlineFood.Application.Features.Comments.Commands.Requests;

public class UpdateCommentCommand : IRequest<bool>
{
	public int Id { get; set; }
	public DateTime CreateDate { get; set; }
	public int RestaurantId { get; set; }
	public int UserId { get; set; }
	public int OrderId { get; set; }
	public int DeliveryTime { get; set; }
	public ScoreEnum Score { get; set; }
	public string Description { get; set; }
	public bool DisplayName { get; set; }
	public string Answer { get; set; }
	public DateTime AnswerDate { get; set; }
}
