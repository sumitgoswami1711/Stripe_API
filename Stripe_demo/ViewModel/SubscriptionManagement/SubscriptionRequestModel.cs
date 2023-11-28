namespace DatingApp.Model.ViewModels.SubscriptionManagement
{
    public class SubscriptionRequestModel
    {
        public long Id { get; set; }

        public string PlanName { get; set; } = null!;

        public string? Description { get; set; }

        public int PlanType { get; set; }

        public int? DurationPeriod { get; set; }

        public int IntervalCount { get; set; }

        public decimal Amount { get; set; }

        public string? Currency { get; set; }

        public int IsTrial { get; set; }

        public int? TrialDays { get; set; }

        public string? StripeProductId { get; set; }

        public string? StripePriceId { get; set; }

        public string? IOSStripeProductId { get; set; }

        public string? IOSStripePriceId { get; set; }

        public decimal? IOSPrice { get; set; }

        public bool IsActive { get; set; }
    }
}
