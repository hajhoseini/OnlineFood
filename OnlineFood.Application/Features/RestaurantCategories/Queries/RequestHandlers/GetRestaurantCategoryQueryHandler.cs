using AutoMapper;
using MediatR;
using OnlineFood.Application.Dtos.RestaurantCategory;
using OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.IReaders.RestaurantCategories;

namespace OnlineFood.Application.Features.RestaurantCategories.Queries.RequestHandlers;	

public class GetRestaurantCategoryQueryHandler : IRequestHandler<GetRestaurantCategoryQuery, RestaurantCategoryDTO>
{
	private readonly IRestaurantCategoryReader _RestaurantCategoryReader;
	private readonly IMapper _mapper;

	public GetRestaurantCategoryQueryHandler(IRestaurantCategoryReader RestaurantCategoryReader, IMapper mapper)
	{
		this._RestaurantCategoryReader = RestaurantCategoryReader;
		_mapper = mapper;
	}

	public async Task<RestaurantCategoryDTO> Handle(GetRestaurantCategoryQuery request, CancellationToken cancellationToken)
	{
		var queryResult = await _RestaurantCategoryReader.GetById(request.Id);
		var result = new RestaurantCategoryDTO();
		result = _mapper.Map<RestaurantCategoryDTO>(queryResult);
		return result;
	}
}
