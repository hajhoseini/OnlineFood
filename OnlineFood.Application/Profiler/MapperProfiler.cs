using AutoMapper;
using OnlineFood.Application.Dtos.Users;
using OnlineFood.Domain.Entities.Users;

namespace OnlineFood.Application.Profiler;

public class Mapperprofiler : Profile
{
    public Mapperprofiler()
    {
        CreateMap<User, UserDto>().ReverseMap();
    }
}