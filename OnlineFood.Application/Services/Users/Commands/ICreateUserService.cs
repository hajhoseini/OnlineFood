using OnlineFood.Common;

namespace OnlineFood.Application.Services.Users.Commands;

public interface ICreateUserService
{
      Task<ResultDto<CreateUserResponseDto>> Execute(CreateUserRequestDto requestDto);
}