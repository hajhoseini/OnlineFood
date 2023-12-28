using MediatR;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.Application.Features.WorkTimes.Queries.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IReaders.Customers;
using OnlineFood.Domain.IReaders.WorkTimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.WorkTimes.Queries.RequestHandlers
{
    public class GetWorkTimeQueryHandler:IRequestHandler<GetWorkTimeQuery,WorkTime>
    {
        private readonly IWorkTimeReader reader;

        public GetWorkTimeQueryHandler(IWorkTimeReader reader)
        {
            this.reader = reader;
        }

        public async Task<WorkTime> Handle(GetWorkTimeQuery request, CancellationToken cancellationToken)
        {
            return await reader.GetById(request.Id);
        }
    }
}
