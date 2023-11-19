
using OnlineFood.Domain.Entities.City;

namespace OnlineFood.Application.Services.Cites.Commands;

public interface ICityCommandService
{
    Task<bool> Create(City city);
    Task<bool> Update(City city);
    Task<bool> Delete(City city);
}
