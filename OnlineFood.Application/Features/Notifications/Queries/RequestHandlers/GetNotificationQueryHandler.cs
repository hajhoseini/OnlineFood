using MediatR;
using OnlineFood.Application.Features.Notifications.Queries.Requests;
using OnlineFood.Domain.Entities.Notifications;
using OnlineFood.Domain.IReaders.Notifications;

namespace OnlineFood.Application.Features.Notifications.Queries.RequestHandlers;

public class GetNotificationQueryHandler : IRequestHandler<GetNotificationQuery, Notification>
{
	private readonly INotificationReader _NotificationReader;

	public GetNotificationQueryHandler(INotificationReader NotificationReader)
	{
		this._NotificationReader = NotificationReader;
	}

	public async Task<Notification> Handle(GetNotificationQuery request, CancellationToken cancellationToken)
	{
		return await _NotificationReader.GetById(request.Id);
	}
}