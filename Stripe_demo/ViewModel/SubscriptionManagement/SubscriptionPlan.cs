namespace DatingApp.Model.ViewModels.SubscriptionManagement
{
    public class SubscriptionPlan
    {
        public  string PriceId { get; set; }
        public string PlanName { get;set; }
        public string PlanDescription { get;set; }  
        public string Charges { get;set; }
        public string Interval { get; set; }
        public int IntervalCount { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
