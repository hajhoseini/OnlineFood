using AutoMapper;
using OnlineFood.Application.Dtos.Customers;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.InterfaceRepositories.Customers;

namespace OnlineFood.Application.Services.Customers.Commands;

public class CustomerCommandService : ICustomerCommandService
{
    private readonly ICustomerRepository _CustomerRepository;
    private readonly IMapper _mapper;

    public CustomerCommandService(ICustomerRepository CustomerRepository, IMapper mapper)
    {
        _CustomerRepository = CustomerRepository;
        _mapper = mapper;
    }

    public async Task<bool> Create(CustomerDto dto)
    {
        var Customer = _mapper.Map<Customer>(dto);
        return await _CustomerRepository.Create(Customer);
    }

    public async Task<bool> Delete(CustomerDto dto)
    {
        var Customer = _mapper.Map<Customer>(dto);
        return await _CustomerRepository.Delete(Customer);
    }

    public async Task<bool> Update(CustomerDto dto)
    {
        var Customer = _mapper.Map<Customer>(dto);
        return await _CustomerRepository.Update(Customer);
    }
}
