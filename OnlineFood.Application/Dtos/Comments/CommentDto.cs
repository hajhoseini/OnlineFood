using OnlineFood.Common.Enums;

namespace OnlineFood.Application.DTOs.Comments;

public class CommentDTO
{
    public int Id { get; set; }
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
