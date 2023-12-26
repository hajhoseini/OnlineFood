using MediatR;

namespace OnlineFood.Application.Features.Notifications.Commands.Requests;

public class CreateNotificationCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime DisplayStartDate { get; set; }
    public DateTime DisplayEndDate { get; set; }
    public string Order { get; set; }
}