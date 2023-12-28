using AutoMapper;
using MediatR;
using OnlineFood.Domain.IRepositories;
using OnlineFood.Application.Features.Notifications.Commands.Requests;
using OnlineFood.Domain.Entities.Notifications;

namespace OnlineFood.Application.Features.Notifications.Commands.RequestHandlers;

public class CreateNotificationCommandHandler : IRequestHandler<CreateNotificationCommand, bool>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateNotificationCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateNotificationCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Notification>(request);
        var result = await _unitOfWork.GenericReposity<Notification>().Create(entity);
        return result;
    }
}