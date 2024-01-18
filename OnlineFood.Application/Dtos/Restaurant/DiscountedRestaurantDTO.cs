using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Dtos.Restaurant
{
    public class DiscountedRestaurantDTO
    {
        [DisplayName("نام رستوران")]
        public string Name { get; set; }
        [DisplayName("درصد تخفیف")]
        public decimal DiscountPercentage { get; set; }
    }
}
