using AutoMapper;
using MediatR;
using OnlineFood.Application.Features.Restaurants.Commands.Requests;
using OnlineFood.Domain.Entities.Resturants;
using OnlineFood.Domain.IRepositories.Restaurants;


namespace OnlineFood.Application.Features.Restaurants.Commands.RequestsHandler
{
    public class UpdateRestaurantCommandHandler:IRequestHandler<UpdateRestaurantCommand,bool>
    {
        private readonly IRestaurantRepository repository;
        private readonly IMapper mapper;

        public UpdateRestaurantCommandHandler(IRestaurantRepository userRepository, IMapper mapper)
        {
            this.repository = userRepository;
            this.mapper = mapper;
        }

        public Task<bool> Handle(UpdateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<Restaurant>(request);
            return repository.Update(entity);
        }
    }
}
