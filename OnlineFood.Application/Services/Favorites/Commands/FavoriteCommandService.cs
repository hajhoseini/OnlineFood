using AutoMapper;
using OnlineFood.Application.Dtos.Favorites;
using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.InterfaceRepositories.Favorites;

namespace OnlineFood.Application.Services.Favorites.Commands;

public class FavoriteCommandService : IFavoriteCommandService
{
    private readonly IFavoriteRepository _FavoriteRepository;
    private readonly IMapper _mapper;

    public FavoriteCommandService(IFavoriteRepository FavoriteRepository, IMapper mapper)
    {
        _FavoriteRepository = FavoriteRepository;
        _mapper = mapper;
    }

    public async Task<bool> Create(FavoriteDto dto)
    {
        var Favorite = _mapper.Map<Favorite>(dto);
        return await _FavoriteRepository.Create(Favorite);
    }

    public async Task<bool> Delete(FavoriteDto dto)
    {
        var Favorite = _mapper.Map<Favorite>(dto);
        return await _FavoriteRepository.Delete(Favorite);
    }

    public async Task<bool> Update(FavoriteDto dto)
    {
        var Favorite = _mapper.Map<Favorite>(dto);
        return await _FavoriteRepository.Update(Favorite);
    }
}
