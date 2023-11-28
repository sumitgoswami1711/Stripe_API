namespace DatingApp.Model.StripeModels.StripeResponse
{
    public class StripePlanListResponse
    {
        public string @object { get; set; }
        public List<Datum> data { get; set; }
        public bool has_more { get; set; }
        public string url { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public string @object { get; set; }
        public bool active { get; set; }
        public object aggregate_usage { get; set; }
        public int amount { get; set; }
        public string amount_decimal { get; set; }
        public string billing_scheme { get; set; }
        public int created { get; set; }
        public string currency { get; set; }
        public string interval { get; set; }
        public int interval_count { get; set; }
        public bool livemode { get; set; }
        public Metadata metadata { get; set; }
        public object nickname { get; set; }
        public string product { get; set; }
        public object tiers_mode { get; set; }
        public object transform_usage { get; set; }
        public object trial_period_days { get; set; }
        public string usage_type { get; set; }
    }
}
