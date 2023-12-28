using MediatR;
using OnlineFood.Application.Features.Notifications.Queries.Requests;
using OnlineFood.Domain.Entities.Notifications;
using OnlineFood.Domain.IReaders.Notifications;

namespace OnlineFood.Application.Features.Notifications.Queries.RequestHandlers;

public class GetListNotificationsQueryHandler : IRequestHandler<GetListNotificationsQuery, List<Notification>>
{
	private readonly INotificationReader _NotificationReader;

	public GetListNotificationsQueryHandler(INotificationReader NotificationReader)
	{
		this._NotificationReader = NotificationReader;
	}

	public async Task<List<Notification>> Handle(GetListNotificationsQuery request, CancellationToken cancellationToken)
	{
		var all = await _NotificationReader.GetList(null, null);
		return all.ToList();
	}
}