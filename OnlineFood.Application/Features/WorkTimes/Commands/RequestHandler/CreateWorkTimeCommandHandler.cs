using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.WorkTimes.Commands.Request;
using OnlineFood.Domain.Entities.WorkTimes;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.WorkTimes.Commands.RequestHandler
{
    public class CreateWorkTimeCommandHandler : IRequestHandler<CreateWorkTimeCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateWorkTimeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<bool> Handle(CreateWorkTimeCommand request,CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<WorkTime>(request);
            var result = await _unitOfWork.GenericReposity<WorkTime>().Create(entity);
            return result;
        }
    }
}
