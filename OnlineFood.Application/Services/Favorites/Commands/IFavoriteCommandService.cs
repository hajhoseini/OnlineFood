using OnlineFood.Application.Dtos.Favorites;

namespace OnlineFood.Application.Services.Favorites.Commands;

public interface IFavoriteCommandService
{
    Task<bool> Create(FavoriteDto dto);
    Task<bool> Update(FavoriteDto dto);
    Task<bool> Delete(FavoriteDto dto);
}
