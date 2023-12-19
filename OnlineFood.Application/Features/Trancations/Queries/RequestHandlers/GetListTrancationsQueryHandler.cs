using MediatR;
using OnlineFood.Application.Features.Trancations.Queries.Requests;
using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.IReaders.Trancations;

namespace OnlineFood.Application.Features.Trancations.Queries.RequestHandlers;

public class GetListTrancationsQueryHandler : IRequestHandler<GetListTrancationsQuery, List<Trancation>>
{
	private readonly ITrancationReader _TrancationReader;

	public GetListTrancationsQueryHandler(ITrancationReader TrancationReader)
	{
		this._TrancationReader = TrancationReader;
	}

	public async Task<List<Trancation>> Handle(GetListTrancationsQuery request, CancellationToken cancellationToken)
	{
		var all = await _TrancationReader.GetList(null, null);
		return all.ToList();
	}
}
