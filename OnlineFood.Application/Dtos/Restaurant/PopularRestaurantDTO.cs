using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Dtos.Restaurant
{
    public class PopularRestaurantDTO
    {
        [DisplayName("نام رستوران")]
        public string Name { get; set; }
        [DisplayName("رتبه محبوبیت")]
        public int PopularityRank { get; set; }
    }
}
