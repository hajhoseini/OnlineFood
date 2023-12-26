using MediatR;
using OnlineFood.Application.Features.Messages.Commands.Requests;
using OnlineFood.Domain.Entities.Messages;
using OnlineFood.Domain.InterfaceRepositories.Messages;

namespace OnlineFood.Application.Features.Messages.Commands.RequestHandlers;

public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, bool>
{
	private readonly IMessageRepository _MessageRepository;

	public DeleteMessageCommandHandler(IMessageRepository messageRepository)
	{
		this._MessageRepository = messageRepository;
	}

	public Task<bool> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
	{
		var message = new Message { Id = request.Id };
		return _MessageRepository.Delete(message);
	}
}