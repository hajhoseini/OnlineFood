
using OnlineFood.Domain.Entities.Cities;

namespace OnlineFood.Application.Services.Cities.Commands;

public interface ICityCommandService
{
    Task<bool> Create(City city);
    Task<bool> Update(City city);
    Task<bool> Delete(City city);
}
