using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.IReaders.Comments;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Comments.Queries;

public class CommentQueryService : ICommentQueryService
{
    private readonly ICommentReader _CommentReader;

    public CommentQueryService(ICommentReader CommentReader)
    {
        _CommentReader = CommentReader;
    }

    public async Task<Comment> GetById(int id)
    {
        return await _CommentReader.GetById(id);
    }

    public async Task<List<Comment>> GetList(Expression<Func<Comment, bool>>? whereVariable = null, string join = "")
    {
        var all = await _CommentReader.GetList();
        return all.ToList();
    }
}
