using MediatR;
using OnlineFood.Application.Features.Trancations.Queries.Requests;
using OnlineFood.Domain.Entities.Trancations;
using OnlineFood.Domain.IReaders.Trancations;

namespace OnlineFood.Application.Features.Trancations.Queries.RequestHandlers;

public class GetTrancationQueryHandler : IRequestHandler<GetTrancationQuery, Trancation>
{
	private readonly ITrancationReader _TrancationReader;

	public GetTrancationQueryHandler(ITrancationReader TrancationReader)
	{
		this._TrancationReader = TrancationReader;
	}

	public async Task<Trancation> Handle(GetTrancationQuery request, CancellationToken cancellationToken)
	{
		return await _TrancationReader.GetById(request.Id);
	}
}
