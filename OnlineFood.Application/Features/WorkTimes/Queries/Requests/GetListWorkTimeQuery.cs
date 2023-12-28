using MediatR;
using OnlineFood.Domain.Entities.WorkTimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.WorkTimes.Queries.Requests
{
    public class GetListWorkTimeQuery:IRequest<List<WorkTime>>
    {
    }
}
