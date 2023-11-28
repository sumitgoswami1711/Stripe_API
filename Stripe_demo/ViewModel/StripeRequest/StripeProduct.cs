namespace DatingApp.Model.StripeModels.StripeRequest
{
    public class StripeProduct
    {
        public string product { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public int PlanType { get; set; }
        public int? interval { get; set; }
        public int? intervalCount { get; set; }
        public int? TrialDays { get; set; }
    }
}
