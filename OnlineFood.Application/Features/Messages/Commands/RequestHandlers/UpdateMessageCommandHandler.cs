using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Messages.Commands.Requests;
using OnlineFood.Domain.Entities.Messages;
using OnlineFood.Domain.InterfaceRepositories.Messages;

namespace OnlineFood.Application.Features.Messages.Commands.RequestHandlers;

public class UpdateMessageCommandHandler : IRequestHandler<UpdateMessageCommand, bool>
{
	private readonly IMessageRepository _MessageRepository;
	private readonly IMapper _mapper;

	public UpdateMessageCommandHandler(IMessageRepository messageRepository, IMapper mapper)
	{
		this._MessageRepository = messageRepository;
		this._mapper = mapper;
	}

	public Task<bool> Handle(UpdateMessageCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Message>(request);
		return _MessageRepository.Update(entity);
	}
}