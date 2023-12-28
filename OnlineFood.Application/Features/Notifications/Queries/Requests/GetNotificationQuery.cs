using MediatR;
using OnlineFood.Domain.Entities.Notifications;

namespace OnlineFood.Application.Features.Notifications.Queries.Requests;

public class GetNotificationQuery : IRequest<Notification>
{
	public int Id { get; set; }
}