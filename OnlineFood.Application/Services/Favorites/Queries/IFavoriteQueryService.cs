using OnlineFood.Domain.Entities.Favorites;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Favorites.Queries;

public interface IFavoriteQueryService
{
    Task<Favorite> GetById(int id);
    Task<List<Favorite>> GetList(Expression<Func<Favorite, bool>>? whereVariable = null, string join = "");
}
