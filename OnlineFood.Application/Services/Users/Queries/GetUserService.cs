using OnlineFood.Common;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories.Users;

namespace OnlineFood.Application.Services.Users.Queries;

public class GetUserService : IGetUserService
{
    private readonly IUserRepository _userRepository;

    public GetUserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public ResultDto<ResponseGetUser> Execute(RequestGetUser requestGetUser)
    {
        try
        {
            var y = _userRepository.GetAll();

            //if (requestGetUser.Id != 0)
            //{
            //    var x = _userRepository.Get(requestGetUser.Id);
            //}

            //var userInDto = y..Select(x => new UserDto()
            //{
            //    username = x.username,
            //    Lastname = x.Lastname,
            //    Firstname = x.Firstname,
            //    password = x.password
            //}).ToList();

            //return new ResultDto<ResponseGetUser>()
            //{
            //    Data = new ResponseGetUser()
            //    {
            //        UserDto = userInDto,
            //    },
            //    IsSuccess = true,
            //    Message = "دریافت شد "
            //};
            return null;
        }
        catch (Exception e)
        {
            return new ResultDto<ResponseGetUser>()
            {
                Data = new ResponseGetUser()
                {
                    UserDto = null,
                },
                IsSuccess = true,
                Message = "دریافت شد "
            };
        }
    }
}
