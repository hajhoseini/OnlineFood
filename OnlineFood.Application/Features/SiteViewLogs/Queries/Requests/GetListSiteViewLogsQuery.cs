using MediatR;
using OnlineFood.Domain.Entities.SiteViewLogs;

namespace OnlineFood.Application.Features.SiteViewLogs.Queries.Requests;

public class GetListSiteViewLogsQuery : IRequest<List<SiteViewLog>>
{
}
