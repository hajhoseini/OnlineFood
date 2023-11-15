using OnlineFood.Domain.Entities.Users;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Users.Queries;

public interface IUserQueryService
{
    Task<User> GetById(int id);
    Task<List<User>> GetList(Expression<Func<User, bool>>? whereVariable = null, string join = "");
}
