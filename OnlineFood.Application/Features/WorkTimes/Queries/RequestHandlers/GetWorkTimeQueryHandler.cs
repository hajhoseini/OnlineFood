using MediatR;
 using OnlineFood.Application.Features.WorkTimes.Queries.Requests;
 using OnlineFood.Domain.Entities.WorkTimes;
 using OnlineFood.Domain.IReaders.WorkTimes;
 

namespace OnlineFood.Application.Features.WorkTimes.Queries.RequestHandlers
{
    public class GetWorkTimeQueryHandler:IRequestHandler<GetWorkTimeQuery,WorkTime>
    {
        private readonly IWorkTimeReader _reader;

        public GetWorkTimeQueryHandler(IWorkTimeReader reader)
        {
            _reader = reader;
        }


        public async Task<WorkTime> Handle(GetWorkTimeQuery request, CancellationToken cancellationToken)
        {
            return await _reader.GetById(request.Id);
        }
    }
}
