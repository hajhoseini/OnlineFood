using MediatR;

namespace OnlineFood.Application.Features.Notifications.Commands.Requests;

public class DeleteNotificationCommand : IRequest<bool>
{
	public int Id { get; set; }
}