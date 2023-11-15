using AutoMapper;
using OnlineFood.Application.Services.Users.Commands;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Profiler;

public class Mapperprofiler : Profile
{
    public Mapperprofiler()
    {
        CreateMap<User, CreateUserRequestDto>().ReverseMap();
    }
}