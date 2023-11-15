using AutoMapper;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.InterfaceRepositories.Users;

namespace OnlineFood.Application.Services.Users.Commands;

public class UserCommandService : IUserCommandService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserCommandService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<bool> Create(UserDto dto)
    {
        var user = _mapper.Map<User>(dto);
        return await _userRepository.Create(user);
    }

    public async Task<bool> Delete(UserDto dto)
    {
        var user = _mapper.Map<User>(dto);
        return await _userRepository.Delete(user);
    }

    public async Task<bool> Update(UserDto dto)
    {
        var user = _mapper.Map<User>(dto);
        return await _userRepository.Update(user);
    }
}
