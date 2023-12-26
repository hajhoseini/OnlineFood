using MediatR;
using OnlineFood.Domain.Entities.Notifications;

namespace OnlineFood.Application.Features.Notifications.Queries.Requests;

public class GetListNotificationsQuery : IRequest<List<Notification>>
{
}