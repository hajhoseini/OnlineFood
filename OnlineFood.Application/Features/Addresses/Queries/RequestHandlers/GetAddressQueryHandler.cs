using MediatR;
using OnlineFood.Application.Features.Addresses.Queries.Requests;
using OnlineFood.Domain.Entities.Addresses;
using OnlineFood.Domain.IReaders.Addresses;

namespace OnlineFood.Application.Features.Addresses.Queries.RequestHandlers;

public class GetAddressQueryHandler : IRequestHandler<GetAddressQuery, Address>
{
	private readonly IAddressReader _AddressReader;

	public GetAddressQueryHandler(IAddressReader addressReader)
	{
		this._AddressReader = addressReader;
	}

	public async Task<Address> Handle(GetAddressQuery request, CancellationToken cancellationToken)
	{
		return await _AddressReader.GetById(request.Id);
	}
}