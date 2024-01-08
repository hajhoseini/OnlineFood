using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.WorkTimes.Commands.Request;
using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IRepositories;
using OnlineFood.Domain.IRepositories.WorkTimes;

namespace OnlineFood.Application.Features.WorkTimes.Commands.RequestHandler
{
    public class UpdateWorkTimeCommandHandler:IRequestHandler<UpdateWorkTimeCommand,bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public UpdateWorkTimeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Handle(UpdateWorkTimeCommand request,CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<WorkTime>(request);
            return await _unitOfWork.GenericReposity<WorkTime>().Update(entity);
        }
    }
}
