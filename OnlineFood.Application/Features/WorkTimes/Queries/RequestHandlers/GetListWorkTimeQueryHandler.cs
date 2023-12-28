using MediatR;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.Application.Features.WorkTimes.Queries.Requests;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IReaders.Customers;
using OnlineFood.Domain.IReaders.WorkTimes;

namespace OnlineFood.Application.Features.WorkTimes.Queries.RequestHandlers
{
    public class GetListWorkTimeQueryHandler:IRequestHandler<GetListWorkTimeQuery,List<WorkTime>>
    {
        private readonly IWorkTimeReader reader;
        public GetListWorkTimeQueryHandler(IWorkTimeReader reader)
        {
            this.reader = reader;
        }
        public async Task<List<WorkTime>> Handle(GetListWorkTimeQuery request, CancellationToken cancellationToken)
        {
            var all = await reader.GetList(null, null);
            return all.ToList();
        }
    }
}
