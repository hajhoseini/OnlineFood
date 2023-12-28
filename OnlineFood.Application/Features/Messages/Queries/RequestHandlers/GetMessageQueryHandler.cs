using MediatR;
using OnlineFood.Application.Features.Messages.Queries.Requests;
using OnlineFood.Domain.Entities.Messages;
using OnlineFood.Domain.IReaders.Messages;

namespace OnlineFood.Application.Features.Messages.Queries.RequestHandlers;

public class GetMessageQueryHandler : IRequestHandler<GetMessageQuery, Message>
{
	private readonly IMessageReader _MessageReader;

	public GetMessageQueryHandler(IMessageReader messageReader)
	{
		this._MessageReader = messageReader;
	}

	public async Task<Message> Handle(GetMessageQuery request, CancellationToken cancellationToken)
	{
		return await _MessageReader.GetById(request.Id);
	}
}