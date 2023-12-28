using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Notifications.Commands.Requests;
using OnlineFood.Domain.Entities.Notifications;
using OnlineFood.Domain.InterfaceRepositories.Notifications;

namespace OnlineFood.Application.Features.Notifications.Commands.RequestHandlers;

public class UpdateNotificationCommandHandler : IRequestHandler<UpdateNotificationCommand, bool>
{
	private readonly INotificationRepository _NotificationRepository;
	private readonly IMapper _mapper;

	public UpdateNotificationCommandHandler(INotificationRepository NotificationRepository, IMapper mapper)
	{
		this._NotificationRepository = NotificationRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateNotificationCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Notification>(request);
		return _NotificationRepository.Update(entity);
	}
}