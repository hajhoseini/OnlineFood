using AutoMapper;
using MediatR;
using OnlineFood.Application.Dtos.Customers;
using OnlineFood.Application.Features.Customers.Queries.Requests;
using OnlineFood.Domain.IReaders.Customers;

namespace OnlineFood.Application.Features.Customers.Queries.RequestHandlers;

public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, CustomerDto>
{
    private readonly IMapper _mapper;
    private readonly ICustomerReader _customerReader;    

    public GetCustomerQueryHandler(IMapper mapper, ICustomerReader customerReader)
	{
		this._mapper = mapper;
        this._customerReader = customerReader;
	}

	public async Task<CustomerDto> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
	{        
		var customerEntity = await _customerReader.GetById(request.Id);
        return _mapper.Map<CustomerDto>(customerEntity);
    }
}
