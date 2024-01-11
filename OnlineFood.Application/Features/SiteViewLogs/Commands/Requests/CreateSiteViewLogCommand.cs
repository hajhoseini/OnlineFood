using MediatR;

namespace OnlineFood.Application.Features.SiteViewLogs.Commands.Requests;

public class CreateSiteViewLogCommand : IRequest<bool>
{
	public int Id { get; set; }
	public DateTime CreateDate { get; set; }
    public string IP { get; set; }
    public string Browser { get; set; }
}
