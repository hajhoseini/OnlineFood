using OnlineFood.Application.Dtos.Comments;

namespace OnlineFood.Application.Services.Comments.Commands;

public interface ICommentCommandService
{
    Task<bool> Create(CommentDto dto);
    Task<bool> Update(CommentDto dto);
    Task<bool> Delete(CommentDto dto);
}
