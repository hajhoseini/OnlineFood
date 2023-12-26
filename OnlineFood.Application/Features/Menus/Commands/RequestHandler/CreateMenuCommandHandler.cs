using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Menus.Commands.Requests;
using OnlineFood.Domain.Entities.Menus;
using OnlineFood.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.Menus.Commands.RequestHandler
{
    public class CreateMenuCommandHandler:IRequestHandler<CreateMenuCommand,bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateMenuCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<bool> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Menu>(request);
            var result = await _unitOfWork.GenericReposity<Menu>().Create(entity);
            return result;
        }
    }
}
