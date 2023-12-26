using MediatR;
using OnlineFood.Application.Features.Messages.Queries.Requests;
using OnlineFood.Domain.Entities.Messages;
using OnlineFood.Domain.IReaders.Messages;

namespace OnlineFood.Application.Features.Messages.Queries.RequestHandlers;

public class GetListMessagesQueryHandler : IRequestHandler<GetListMessagesQuery, List<Message>>
{
	private readonly IMessageReader _MessageReader;

	public GetListMessagesQueryHandler(IMessageReader messageReader)
	{
		this._MessageReader = messageReader;
	}

	public async Task<List<Message>> Handle(GetListMessagesQuery request, CancellationToken cancellationToken)
	{
		var all = await _MessageReader.GetList(null, null);
		return all.ToList();
	}
}