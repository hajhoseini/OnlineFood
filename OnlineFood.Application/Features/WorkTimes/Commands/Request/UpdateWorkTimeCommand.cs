using MediatR;
using OnlineFood.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Application.Features.WorkTimes.Commands.Request
{
    public class UpdateWorkTimeCommand:IRequest<bool>
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int RestaurantId { get; set; }
        public WeekDaysEnum Day { get; set; }
        public MealEnum Deal { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
