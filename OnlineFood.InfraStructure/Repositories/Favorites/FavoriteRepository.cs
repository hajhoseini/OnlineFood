using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.InterfaceRepositories.Favorites;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Favorites;

public class FavoriteRepository : GenericRepository<Favorite>, IFavoriteRepository
{
    public FavoriteRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}