using MediatR;
using OnlineFood.Domain.Entities.WorkTimes;

namespace OnlineFood.Application.Features.WorkTimes.Queries.Requests
{
    public class GetWorkTimeQuery:IRequest<WorkTime>
    {
        public int Id { get; set; }
    }
}
