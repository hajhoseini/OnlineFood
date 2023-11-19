using OnlineFood.Common.Enums;
using OnlineFood.Domain.Entities.Base;

namespace OnlineFood.Domain.Entities.WorkTimes;

public class WorkTime : BaseEntity
{
    public int RestaurantId { get; set; }
    public WeekDaysEnum Day { get; set; }
    public MealEnum Deal { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
}
