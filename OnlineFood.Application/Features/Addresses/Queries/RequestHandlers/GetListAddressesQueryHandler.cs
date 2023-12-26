using MediatR;
using OnlineFood.Application.Features.Addresses.Queries.Requests;
using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.IReaders.Addresses;

namespace OnlineFood.Application.Features.Notifications.Queries.RequestHandlers;

public class GetListAddressesQueryHandler : IRequestHandler<GetListAddressesQuery, List<Address>>
{
	private readonly IAddressReader _AddressReader;

	public GetListAddressesQueryHandler(IAddressReader addressReader)
	{
		this._AddressReader = addressReader;
	}

	public async Task<List<Address>> Handle(GetListAddressesQuery request, CancellationToken cancellationToken)
	{
		var all = await _AddressReader.GetList(null, null);
		return all.ToList();
	}
}