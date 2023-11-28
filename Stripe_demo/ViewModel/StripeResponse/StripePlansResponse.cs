using System.Text.Json.Serialization;

namespace DatingApp.Model.StripeModels.StripeResponse
{
    public class StripePlansResponse
    {
        public string id { get; set; }
        public string @object { get; set; }
        public bool active { get; set; }
        public string billing_scheme { get; set; }
        public int created { get; set; }
        public string currency { get; set; }
        public object custom_unit_amount { get; set; }
        public bool livemode { get; set; }
        public object lookup_key { get; set; }
        public Metadata metadata { get; set; }
        public object nickname { get; set; }
        public string product { get; set; }
        [JsonPropertyName("recurring")]
        public PlanRecurring recurring { get; set; }
        public string tax_behavior { get; set; }
        public object tiers_mode { get; set; }
        public object transform_quantity { get; set; }
        public string type { get; set; }
        public int unit_amount { get; set; }
        public string unit_amount_decimal { get; set; }
    }

    public class PlanRecurring
    {
        public object aggregate_usage { get; set; }
        public string interval { get; set; }
        public int interval_count { get; set; }
        public object trial_period_days { get; set; }
        public string usage_type { get; set; }
    }

    public class Metadata
    {
    }
}
