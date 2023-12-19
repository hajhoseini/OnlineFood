using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Comments.Commands.Requests;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Comments.Commands.RequestHandlers;

public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateCommentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		this._unitOfWork = unitOfWork;
		this._mapper = mapper;
	}

	public async Task<bool> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Comment>(request);
		var result = await _unitOfWork.GenericReposity<Comment>().Update(entity);
		return result;
	}
}
