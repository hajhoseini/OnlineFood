using AutoMapper;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Services.Users.Commands;

public class UserCommandService : IUserCommandService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

    public UserCommandService(IUnitOfWork unitOfWork, IMapper mapper)
    {
		_unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<bool> Create(UserDto dto)
    {
        var entity = _mapper.Map<User>(dto);
		var result = await _unitOfWork.GenericReposity<User>().Create(entity);
		return result;
	}

    public async Task<bool> Delete(UserDto dto)
    {
		var entity = _mapper.Map<User>(dto);
		var result = await _unitOfWork.GenericReposity<User>().Delete(entity);
		return result;
	}

    public async Task<bool> Update(UserDto dto)
    {
		var entity = _mapper.Map<User>(dto);
		var result = await _unitOfWork.GenericReposity<User>().Update(entity);
		return result;
	}
}
