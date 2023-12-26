using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.WorkTimes.Commands.Request;
using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IRepositories.WorkTimes;

namespace OnlineFood.Application.Features.WorkTimes.Commands.RequestHandler
{
    public class UpdateWorkTimeCommandHandler:IRequestHandler<UpdateWorkTimeCommand,bool>
    {
        private readonly IWorkTimeRepository repository;
        private readonly IMapper mapper;
        public UpdateWorkTimeCommandHandler(IWorkTimeRepository repository,IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public Task<bool> Handle(UpdateWorkTimeCommand request,CancellationToken cancellationToken)
        {
            var entity = mapper.Map<WorkTime>(request);
            return repository.Update(entity);
        }
    }
}
