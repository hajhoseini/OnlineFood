using AutoMapper;
using OnlineFood.Application.Dtos.Comments;
using OnlineFood.Domain.Entities.Comments;
using OnlineFood.Domain.InterfaceRepositories.Comments;

namespace OnlineFood.Application.Services.Comments.Commands;

public class CommentCommandService : ICommentCommandService
{
    private readonly ICommentRepository _CommentRepository;
    private readonly IMapper _mapper;

    public CommentCommandService(ICommentRepository CommentRepository, IMapper mapper)
    {
        _CommentRepository = CommentRepository;
        _mapper = mapper;
    }

    public async Task<bool> Create(CommentDto dto)
    {
        var Comment = _mapper.Map<Comment>(dto);
        return await _CommentRepository.Create(Comment);
    }

    public async Task<bool> Delete(CommentDto dto)
    {
        var Comment = _mapper.Map<Comment>(dto);
        return await _CommentRepository.Delete(Comment);
    }

    public async Task<bool> Update(CommentDto dto)
    {
        var Comment = _mapper.Map<Comment>(dto);
        return await _CommentRepository.Update(Comment);
    }
}
