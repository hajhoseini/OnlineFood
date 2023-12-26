using AutoMapper;
using MediatR;
using OnlineFood.Domain.IRepositories;
using OnlineFood.Application.Features.Messages.Commands.Requests;
using OnlineFood.Domain.Entities.Messages;

namespace OnlineFood.Application.Features.Messages.Commands.RequestHandlers;

public class CreateMessageCommandHandler:IRequestHandler<CreateMessageCommand,bool>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateMessageCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this._unitOfWork = unitOfWork;
        this._mapper = mapper;
    }

    public async Task<bool> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Message>(request);
        var result = await _unitOfWork.GenericReposity<Message>().Update(entity);
        return result;
    }
}