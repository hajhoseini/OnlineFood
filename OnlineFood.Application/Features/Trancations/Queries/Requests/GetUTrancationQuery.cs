using MediatR;
using OnlineFood.Domain.Entities.Trancations;

namespace OnlineFood.Application.Features.Trancations.Queries.Requests;

public class GetTrancationQuery : IRequest<Trancation>
{
	public int Id { get; set; }
}
