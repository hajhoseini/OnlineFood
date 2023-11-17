using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.IReaders.Comments;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Readers.Comments;

public class CommentReader : GenericReader<Comment>, ICommentReader
{
    public CommentReader(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}