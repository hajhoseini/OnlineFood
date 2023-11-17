using OnlineFood.Domain.Entities.Customers;
using System.Linq.Expressions;

namespace OnlineFood.Application.Services.Customers.Queries;

public interface ICustomerQueryService
{
    Task<Customer> GetById(int id);
    Task<List<Customer>> GetList(Expression<Func<Customer, bool>>? whereVariable = null, string join = "");
}
