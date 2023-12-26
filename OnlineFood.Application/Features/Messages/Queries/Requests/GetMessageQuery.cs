using MediatR;
using OnlineFood.Domain.Entities.Messages;

namespace OnlineFood.Application.Features.Messages.Queries.Requests;

public class GetMessageQuery : IRequest<Message>
{
	public int Id { get; set; }
}