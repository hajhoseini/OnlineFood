using OnlineFood.Application.Dtos.Customers;

namespace OnlineFood.Application.Services.Customers.Commands;

public interface ICustomerCommandService
{
    Task<bool> Create(CustomerDto dto);
    Task<bool> Update(CustomerDto dto);
    Task<bool> Delete(CustomerDto dto);
}
