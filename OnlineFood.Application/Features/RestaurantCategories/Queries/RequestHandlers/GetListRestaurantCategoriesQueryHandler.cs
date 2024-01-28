using AutoMapper;
using MediatR;
using OnlineFood.Application.DTOs.RestaurantCategory;
using OnlineFood.Application.Features.RestaurantCategories.Queries.Requests;
using OnlineFood.Domain.IReaders.RestaurantCategories;

namespace OnlineFood.Application.Features.RestaurantCategories.Queries.RequestHandlers;

public class GetListRestaurantCategoriesQueryHandler : IRequestHandler<GetListRestaurantCategoriesQuery, List<RestaurantCategoryDTO>>
{
	private readonly IRestaurantCategoryReader _RestaurantCategoryReader;
	private readonly IMapper _mapper;

	public GetListRestaurantCategoriesQueryHandler(IRestaurantCategoryReader RestaurantCategoryReader,IMapper mapper)
	{
		_RestaurantCategoryReader = RestaurantCategoryReader;
		_mapper = mapper;
	}

	public async Task<List<RestaurantCategoryDTO>> Handle(GetListRestaurantCategoriesQuery request, CancellationToken cancellationToken)
	{
		var all = await _RestaurantCategoryReader.GetList(null, null);
		var result = new List<RestaurantCategoryDTO>();
		foreach (var item in all)
		{
			var i=_mapper.Map<RestaurantCategoryDTO>(item);
			result.Add(i);
		}
		return result;
	}
}