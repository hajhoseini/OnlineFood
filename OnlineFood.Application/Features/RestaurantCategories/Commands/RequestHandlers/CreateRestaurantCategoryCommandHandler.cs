using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.RestaurantCategories.Commands.Requests;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.RestaurantCategories.Commands.RequestHandlers;

public class CreateRestaurantCategoryCommandHandler : IRequestHandler<CreateRestaurantCategoryCommand, bool>
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateRestaurantCategoryCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<bool> Handle(CreateRestaurantCategoryCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<RestaurantCategory>(request);
		var result = await _unitOfWork.GenericReposity<RestaurantCategory>().Create(entity);
		return result;
	}
}
