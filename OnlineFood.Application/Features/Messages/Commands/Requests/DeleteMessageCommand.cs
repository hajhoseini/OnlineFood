using MediatR;

namespace OnlineFood.Application.Features.Messages.Commands.Requests;

public class DeleteMessageCommand : IRequest<bool>
{
	public int Id { get; set; }
}