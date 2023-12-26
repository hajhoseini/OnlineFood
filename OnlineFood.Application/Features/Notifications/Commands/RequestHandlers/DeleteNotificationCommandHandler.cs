using MediatR;
using OnlineFood.Application.Features.Notifications.Commands.Requests;
using OnlineFood.Domain.Entities.Notifications;
using OnlineFood.Domain.InterfaceRepositories.Notifications;

namespace OnlineFood.Application.Features.Notifications.Commands.RequestHandlers;

public class DeleteNotificationCommandHandler : IRequestHandler<DeleteNotificationCommand, bool>
{
	private readonly INotificationRepository _NotificationRepository;

	public DeleteNotificationCommandHandler(INotificationRepository NotificationRepository)
	{
		this._NotificationRepository = NotificationRepository;
	}

	public Task<bool> Handle(DeleteNotificationCommand request, CancellationToken cancellationToken)
	{
		var Notification = new Notification { Id = request.Id };
		return _NotificationRepository.Delete(Notification);
	}
}