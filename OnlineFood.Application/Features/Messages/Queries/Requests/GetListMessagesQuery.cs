using MediatR;
using OnlineFood.Domain.Entities.Messages;

namespace OnlineFood.Application.Features.Messages.Queries.Requests;

public class GetListMessagesQuery : IRequest<List<Message>>
{
}