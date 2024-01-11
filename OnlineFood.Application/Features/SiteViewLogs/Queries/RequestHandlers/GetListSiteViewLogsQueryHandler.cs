using MediatR;
using OnlineFood.Application.Features.SiteViewLogs.Queries.Requests;
using OnlineFood.Domain.Entities.SiteViewLogs;
using OnlineFood.Domain.IReaders.SiteViewLogs;

namespace OnlineFood.Application.Features.SiteViewLogs.Queries.RequestHandlers;

public class GetListSiteViewLogsQueryHandler : IRequestHandler<GetListSiteViewLogsQuery, List<SiteViewLog>>
{
	private readonly ISiteViewLogReader _SiteViewLogReader;

	public GetListSiteViewLogsQueryHandler(ISiteViewLogReader SiteViewLogReader)
	{
		this._SiteViewLogReader = SiteViewLogReader;
	}

	public async Task<List<SiteViewLog>> Handle(GetListSiteViewLogsQuery request, CancellationToken cancellationToken)
	{
		var all = await _SiteViewLogReader.GetList(null, null);
		return all.ToList();
	}
}
