using AutoMapper;
using MediatR;
using OnlineFood.Application.DTOs.Customers;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.Domain.IReaders.Customers;

namespace OnlineFood.Application.Features.Customers.Queries.RequestHandlers;

public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, CustomerDTO>
{
    private readonly IMapper _mapper;
    private readonly ICustomerReader _customerReader;    

    public GetCustomerQueryHandler(IMapper mapper, ICustomerReader customerReader)
	{
		this._mapper = mapper;
        this._customerReader = customerReader;
	}

	public async Task<CustomerDTO> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
	{        
		var customerEntity = await _customerReader.GetById(request.Id);
        return _mapper.Map<CustomerDTO>(customerEntity);
    }
}
