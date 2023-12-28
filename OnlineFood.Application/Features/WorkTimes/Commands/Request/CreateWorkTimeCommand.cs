using MediatR;
using OnlineFood.Common.Enums;

namespace OnlineFood.Application.Features.WorkTimes.Commands.Request
{
    public class CreateWorkTimeCommand : IRequest<bool>
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
