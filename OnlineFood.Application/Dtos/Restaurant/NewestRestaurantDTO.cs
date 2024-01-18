using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Dtos.Restaurant
{
    public class NewestRestaurantDTO
    {
        [DisplayName("نام رستوران")]
        public string Name { get; set; }
        [DisplayName("تاریخ اضافه شدن رستوران ")]
        public DateTime OpeningDate { get; set; }
    }
}
