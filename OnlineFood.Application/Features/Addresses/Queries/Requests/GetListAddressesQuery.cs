using MediatR;
using OnlineFood.Domain.Entities.Addresses;

namespace OnlineFood.Application.Features.Addresses.Queries.Requests;

public class GetListAddressesQuery : IRequest<List<Address>>
{
}