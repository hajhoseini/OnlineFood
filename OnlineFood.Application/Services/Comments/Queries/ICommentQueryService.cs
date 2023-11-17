using OnlineFood.Domain.Entities.Comments;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Comments.Queries;

public interface ICommentQueryService
{
    Task<Comment> GetById(int id);
    Task<List<Comment>> GetList(Expression<Func<Comment, bool>>? whereVariable = null, string join = "");
}
