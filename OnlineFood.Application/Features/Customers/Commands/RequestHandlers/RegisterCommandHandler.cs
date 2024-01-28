﻿using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Customers.Commands.Requests;
using OnlineFood.Application.Features.Users.Commands.Requests;
using OnlineFood.Common;
using OnlineFood.Domain.Entities.Customers;
using OnlineFood.Domain.Entities.Users;
using OnlineFood.Domain.IReaders.Users;
using OnlineFood.Domain.IRepositories;

namespace OnlineFood.Application.Features.Customers.Commands.RequestHandlers;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ResultDTO>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IUserReader _userReader;

    public RegisterCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IUserReader userReader)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userReader = userReader;
    }

    public async Task<ResultDTO> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        ResultDTO resultDTO;

        //چک تکراری نبودن نام کاربری
        var allUser = await _userReader.GetList(null);
        int count = allUser.Where(p => p.UserName == request.register.MobileNumber).Count();
        if (count > 0)
        {
            resultDTO = new ResultDTO()
            {
                IsSuccess = false,
                Message = "شماره موبایل وارد شده تکراری است"
            };

            return resultDTO;
        }

        //درج کاربر
        CreateUserCommand userCommand = new()
        {
            UserName = request.register.MobileNumber,
            Password = request.register.Password
        };
        var userEntity = _mapper.Map<User>(userCommand);
        userEntity.Id = Convert.ToString(allUser.Count() + 1);
        var result = await _unitOfWork.GenericReposity<User>().Create(userEntity);

        //allUser = await _userReader.GetList(null);
        //var user = allUser.Where(p => p.UserName == request.register.MobileNumber).FirstOrDefault();

        CreateCustomerCommand customerCommand = new()
        {
            MobileNumber = request.register.MobileNumber,
            Email = request.register.Email,
            //UserId = Convert.ToInt32(user.Id)
            UserId = Convert.ToInt32(userEntity.Id)
        };
        var customerEntity = _mapper.Map<Customer>(customerCommand);
        customerEntity.FirstName = "";
        customerEntity.LastName = "";
        result = await _unitOfWork.GenericReposity<Customer>().Create(customerEntity);

        resultDTO = new ResultDTO()
        {
            IsSuccess = true,
        };

        return resultDTO;
    }
}
