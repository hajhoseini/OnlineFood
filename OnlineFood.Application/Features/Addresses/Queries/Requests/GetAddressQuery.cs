using MediatR;
using OnlineFood.Domain.Entities.Addresses;

namespace OnlineFood.Application.Features.Addresses.Queries.Requests;

public class GetAddressQuery : IRequest<Address>
{
	public int Id { get; set; }
}