using MediatR;
using OnlineFood.Domain.Entities.Trancations;

namespace OnlineFood.Application.Features.Trancations.Queries.Requests;

public class GetListTrancationsQuery : IRequest<List<Trancation>>
{
}
