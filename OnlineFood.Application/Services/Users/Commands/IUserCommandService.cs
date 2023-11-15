using OnlineFood.Application.Dtos.Users;

namespace OnlineFood.Application.Services.Users.Commands;

public interface IUserCommandService
{
    Task<bool> Create(UserDto dto);
    Task<bool> Update(UserDto dto);
    Task<bool> Delete(UserDto dto);
}
