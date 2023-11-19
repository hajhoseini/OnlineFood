using OnlineFood.Common.Enums;
using OnlineFood.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFood.Domain.Entities.WorkTime
{
    internal class WorkTime : BaseEntity
    {
        public WeekDaysEnum Day { get; set; }
        public MealEnum Deal { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
