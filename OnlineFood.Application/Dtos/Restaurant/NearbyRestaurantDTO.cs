using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Dtos.Restaurant
{
    public class NearbyRestaurantDTO
    {
        [DisplayName("نام رستوران")]
        public string Name { get; set; }

        public double Distance { get; set; }
    }
}
