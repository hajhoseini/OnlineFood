using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.IReaders.Users;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Users.Queries;

public class UserQueryService : IUserQueryService
{
    private readonly IUserReader _userReader;

    public UserQueryService(IUserReader userReader)
    {
        _userReader = userReader;
    }

    public async Task<User> GetById(int id)
    {
        return await _userReader.GetById(id);
    }

    public async Task<List<User>> GetList(Expression<Func<User, bool>>? whereVariable = null, string join = "")
    {
        var all = await _userReader.GetList();
        return all.ToList();
    }
}
