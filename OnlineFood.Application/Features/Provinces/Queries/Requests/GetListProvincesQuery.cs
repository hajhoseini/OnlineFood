using MediatR;
using OnlineFood.Application.Dtos.Province;

namespace OnlineFood.Application.Features.Provinces.Queries.Requests;

public class GetListProvincesQuery : IRequest<List<ProvinceDTO>>
{
}
