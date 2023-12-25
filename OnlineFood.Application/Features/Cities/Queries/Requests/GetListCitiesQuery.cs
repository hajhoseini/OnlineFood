using MediatR;
using OnlineFood.Domain.Entities.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.Requests;

public class GetListCitesQuery : IRequest<List<City>>
{
}
