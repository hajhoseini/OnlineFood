using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.WorkTimes.Commands.Request;
using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.WorkTimes.Commands.RequestHandler
{
    public class CreateWorkTimeCommandHandler : IRequestHandler<CreateWorkTimeCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public CreateWorkTimeCommandHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(CreateWorkTimeCommand request,CancellationToken cancellationToken)
        {
            var entity = mapper.Map<WorkTime>(request);
            var result = await unitOfWork.GenericReposity<WorkTime>().Create(entity);
            return result;
        }
    }
}
