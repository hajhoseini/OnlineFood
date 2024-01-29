using MediatR;
using OnlineFood.Application.DTOs.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.Requests;

public class GetListCitesQuery : IRequest<List<CityDTO>>
{
}
