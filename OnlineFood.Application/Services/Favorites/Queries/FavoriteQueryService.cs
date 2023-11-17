using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.IReaders.Favorites;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Favorites.Queries;

public class FavoriteQueryService : IFavoriteQueryService
{
    private readonly IFavoriteReader _FavoriteReader;

    public FavoriteQueryService(IFavoriteReader FavoriteReader)
    {
        _FavoriteReader = FavoriteReader;
    }

    public async Task<Favorite> GetById(int id)
    {
        return await _FavoriteReader.GetById(id);
    }

    public async Task<List<Favorite>> GetList(Expression<Func<Favorite, bool>>? whereVariable = null, string join = "")
    {
        var all = await _FavoriteReader.GetList();
        return all.ToList();
    }
}
