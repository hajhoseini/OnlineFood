using OnlineFood.Domain.Entities.Favorites;
using OnlineFood.Domain.IReaders.Favorites;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Favorites;

public class FavoriteReader : GenericReader<Favorite>, IFavoriteReader
{
    public FavoriteReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}