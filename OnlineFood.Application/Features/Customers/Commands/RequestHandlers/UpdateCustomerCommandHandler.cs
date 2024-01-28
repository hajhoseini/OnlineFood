using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Common;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.InterfaceRepositories.Customers;

namespace OnlineFood.Application.Features.Customers.Commands.RequestHandlers;

public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, ResultDto>
{
	private readonly ICustomerRepository _CustomerRepository;
	private readonly IMapper _mapper;

	public UpdateCustomerCommandHandler(ICustomerRepository CustomerRepository, IMapper mapper)
	{
		this._CustomerRepository = CustomerRepository;
		this._mapper = mapper;
	}

	public async Task<ResultDto> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
	{
		var entity = _mapper.Map<Customer>(request.customer);
		bool result = await _CustomerRepository.Update(entity);

		ResultDto resultDto = new ResultDto();

		resultDto.IsSuccess = result;

        if (!result)
		{
			resultDto.Message = "خطایی در ویرایش رخ داده است";
        }

        return resultDto;        
	}
}
