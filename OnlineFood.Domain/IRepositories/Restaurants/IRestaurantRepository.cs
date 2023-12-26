using OnlineFood.Domain.Entities.Resturants;
using OnlineFood.Domain.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Domain.IRepositories.Restaurants
{
    public interface IRestaurantRepository:IGenericRepository<Restaurant>
    {
    }
}
