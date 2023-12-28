using MediatR;
using OnlineFood.Application.Features.Restaurants.Commands.Requests;
using OnlineFood.Domain.Entities.Resturants;
using OnlineFood.Domain.IRepositories.Restaurants;

namespace OnlineFood.Application.Features.Restaurants.Commands.RequestsHandler
{
    public class DeleteRestaurantCommandHandler:IRequestHandler<DeleteRestaurantCommand,bool>
    {
        private readonly IRestaurantRepository repository;
        public DeleteRestaurantCommandHandler(IRestaurantRepository repository)
        {
            this.repository = repository;
        }

        public Task<bool> Handle(DeleteRestaurantCommand request, CancellationToken cancellationToken)
        {
            Restaurant entity = new Restaurant { Id = request.Id };
            return repository.Delete(entity);
        }
    }
}
