using OnlineFood.Common;

namespace OnlineFood.Application.Services.Users.Queries;

public interface IGetUserService
{
    ResultDto<ResponseGetUser> Execute(RequestGetUser requestGetUser);
}