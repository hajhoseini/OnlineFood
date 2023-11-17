using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.InterfaceRepositories.Comments;
using OnlineFood.InfraStructure.DBContext;

namespace OnlineFood.InfraStructure.Repositories.Comments;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
    public CommentRepository(OnlineFoodDBConext dbContext) : base(dbContext)
    {
    }
}