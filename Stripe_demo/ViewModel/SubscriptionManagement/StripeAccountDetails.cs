namespace DatingApp.Model.ViewModels.Token
{
    public class StripeAccountDetails
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CustomerId { get; set; } = null!;
        public string? SubscriptionId { get; set; }
        public string? PlanId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? CancelDate { get; set; }
        public string? ScheduleId { get; set; }
        public bool? SubsriptionSchedule { get; set; } = false;
        public bool? ScheduleCompleted { get; set; } = false;
    }
}
