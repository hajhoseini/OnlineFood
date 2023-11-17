using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.IReaders.Customers;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Customers.Queries;

public class CustomerQueryService : ICustomerQueryService
{
    private readonly ICustomerReader _CustomerReader;

    public CustomerQueryService(ICustomerReader CustomerReader)
    {
        _CustomerReader = CustomerReader;
    }

    public async Task<Customer> GetById(int id)
    {
        return await _CustomerReader.GetById(id);
    }

    public async Task<List<Customer>> GetList(Expression<Func<Customer, bool>>? whereVariable = null, string join = "")
    {
        var all = await _CustomerReader.GetList();
        return all.ToList();
    }
}
