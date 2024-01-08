using MediatR;
using OnlineFood.Domain.Entities.WorkTimes;
 
namespace OnlineFood.Application.Features.WorkTimes.Queries.Requests
{
    public class GetListWorkTimeQuery:IRequest<List<WorkTime>>
    {
    }
}
