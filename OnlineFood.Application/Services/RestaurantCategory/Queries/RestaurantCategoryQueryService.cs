using Microsoft.AspNetCore.Identity;
using OnlineFood.Application.Dtos.RestaurantCategory;
using OnlineFood.Domain.Entities.RestaurantCategories;
using OnlineFood.Domain.IReaders.RestaurantCategories;
using System.Linq;

namespace OnlineFood.Application.Services.RestaurantCategory.Queries;

public class RestaurantCategoryQueryService : IRestaurantCategoryQueryService
{
    private readonly IRestaurantCategoryReader _RestaurantCategoryReader;

    public RestaurantCategoryQueryService(IRestaurantCategoryReader RestaurantCategoryReader)
    {
        _RestaurantCategoryReader = RestaurantCategoryReader;
    }

    public async Task<List<RestaurantCategoryDTO>> List()
    {
        var all = await _RestaurantCategoryReader.GetList(null);
        var dtoList = all.Select(category => new RestaurantCategoryDTO
        {

        }).ToList();

        return dtoList;
    }




}