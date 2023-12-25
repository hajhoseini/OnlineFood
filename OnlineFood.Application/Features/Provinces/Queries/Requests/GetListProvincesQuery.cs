using MediatR;
using OnlineFood.Domain.Entities.Provinces;

namespace OnlineFood.Application.Features.Provinces.Queries.Requests;

public class GetListProvincesQuery : IRequest<List<Province>>
{
}
