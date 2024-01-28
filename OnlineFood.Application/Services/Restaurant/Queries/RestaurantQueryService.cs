using Microsoft.AspNetCore.Identity;
using OnlineFood.Application.DTOs.Restaurant;
using OnlineFood.Domain.Entities.Resturants;
using OnlineFood.Domain.IReaders.Restaurants;
using System.Linq;

namespace OnlineFood.Application.Services.Restaurant.Queries;

public class RestaurantQueryService : IRestaurantQueryService
{
    private readonly IRestaurantReader _RestaurantReader;

    public RestaurantQueryService(IRestaurantReader RestaurantReader)
    {
        _RestaurantReader = RestaurantReader;
    }

    public async Task<List<DiscountedRestaurantDTO>> DiscountedList()
    {
        var all = await _RestaurantReader.GetList(null);
        var dtoList = all.Select(category => new DiscountedRestaurantDTO
        {

        }).ToList();
        return dtoList;
    }

    public async Task<List<NearbyRestaurantDTO>> NearbyList()
    {
        var all = await _RestaurantReader.GetList(null);
        var dtoList = all.Select(category => new NearbyRestaurantDTO
        {

        }).ToList();
        return dtoList;
    }

    public async Task<List<NewestRestaurantDTO>> NewestList()
    {
        var all = await _RestaurantReader.GetList(null);
        var dtoList = all.Select(category => new NewestRestaurantDTO
        {

        }).ToList();
        return dtoList;
    }

    public async Task<List<PopularRestaurantDTO>> PopularList()
    {
        var all = await _RestaurantReader.GetList(null);
        var dtoList = all.Select(category => new PopularRestaurantDTO
        {

        }).ToList();
        return dtoList;
    }
}