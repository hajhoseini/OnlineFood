using MediatR;
using OnlineFood.Application.Features.WorkTimes.Queries.Requests;
using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IReaders.WorkTimes;

namespace OnlineFood.Application.Features.WorkTimes.Queries.RequestHandlers
{
    public class GetListWorkTimeQueryHandler : IRequestHandler<GetListWorkTimeQuery, List<WorkTime>>
    {
        private readonly IWorkTimeReader _reader;

        public GetListWorkTimeQueryHandler(IWorkTimeReader reader)
        {
            _reader = reader;
        }

        public async Task<List<WorkTime>> Handle(GetListWorkTimeQuery request, CancellationToken cancellationToken)
        {
            var all = await _reader.GetList();
            return all.ToList();
        }
    }
}