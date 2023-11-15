using AutoMapper;
using OnlineFood.Common;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories.Users;

namespace OnlineFood.Application.Services.Users.Commands;

public class CreateUserService : ICreateUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public CreateUserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<ResultDto<CreateUserResponseDto>> Execute(CreateUserRequestDto requestDto)
    {
        var getAll = await _userRepository.GetAll();
        var checking = getAll.Where(x => x.UserName == requestDto.UserName);
        try
        {
            if (checking.Count() > 0)
            {
                return new ResultDto<CreateUserResponseDto>()
                {
                    IsSuccess = false,
                    Message = "کاربری با این نام کاربری موجود است",
                };
            }

            var user = _mapper.Map<User>(requestDto);
            var result = await _userRepository.Create(user);
            return new ResultDto<CreateUserResponseDto>()
            {
                IsSuccess = true,
                Message = "عملیات با موفقیت انجام شد",
                Data = new CreateUserResponseDto()
                {
                    Id = result.Id
                }
            };
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            return new ResultDto<CreateUserResponseDto>()
            {
                IsSuccess = false,
                Message = "حادثه ایی رخ داده است",
            };
        }
    }
}