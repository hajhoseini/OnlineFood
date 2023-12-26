using MediatR;
using OnlineFood.Application.Features.WorkTimes.Commands.Request;
using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IRepositories.WorkTimes;

namespace OnlineFood.Application.Features.WorkTimes.Commands.RequestHandler
{
    public class DeleteWorkTimeCommandHandler:IRequestHandler<DeleteWorkTimeCommand,bool>
    {
        private readonly IWorkTimeRepository repository;
        public DeleteWorkTimeCommandHandler(IWorkTimeRepository repository)
        {
            this.repository = repository;
        }
        public Task<bool> Handle(DeleteWorkTimeCommand request,CancellationToken cancellationToken)
        {
            WorkTime workTime = new WorkTime { Id = request.Id };
            return repository.Delete(workTime);
        }
    }
}
