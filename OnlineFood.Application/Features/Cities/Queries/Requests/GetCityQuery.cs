using MediatR;
using OnlineFood.Domain.Entities.Cities;

namespace OnlineFood.Application.Features.Cities.Queries.Requests;

public class GetCityQuery : IRequest<City>
{
	public int Id { get; set; }
}
