using MediatR;
using OnlineFood.Application.Dtos.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.Requests;

public class GetListCitesQuery : IRequest<List<CityDTO>>
{
}
