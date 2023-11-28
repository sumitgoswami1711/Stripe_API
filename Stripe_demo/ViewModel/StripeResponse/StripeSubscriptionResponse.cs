﻿namespace DatingApp.Model.StripeModels.StripeResponse
{
    public class StripeSubscriptionResponse
    {
        public string id { get; set; }
        public string @object { get; set; }
        public object application { get; set; }
        public object application_fee_percent { get; set; }
        public AutomaticTax automatic_tax { get; set; }
        public int billing_cycle_anchor { get; set; }
        public object billing_thresholds { get; set; }
        public object cancel_at { get; set; }
        public bool cancel_at_period_end { get; set; }
        public object canceled_at { get; set; }
        public CancellationDetails cancellation_details { get; set; }
        public string collection_method { get; set; }
        public int created { get; set; }
        public string currency { get; set; }
        public int current_period_end { get; set; }
        public int current_period_start { get; set; }
        public string customer { get; set; }
        public object days_until_due { get; set; }
        public string default_payment_method { get; set; }
        public object default_source { get; set; }
        public List<object> default_tax_rates { get; set; }
        public object description { get; set; }
        public object discount { get; set; }
        public object ended_at { get; set; }
        public Items items { get; set; }
        public string latest_invoice { get; set; }
        public bool livemode { get; set; }
        public Metadata metadata { get; set; }
        public object next_pending_invoice_item_invoice { get; set; }
        public object on_behalf_of { get; set; }
        public object pause_collection { get; set; }
        public PaymentSettings payment_settings { get; set; }
        public object pending_invoice_item_interval { get; set; }
        public object pending_setup_intent { get; set; }
        public object pending_update { get; set; }
        public Plan plan { get; set; }
        public int quantity { get; set; }
        public object schedule { get; set; }
        public int start_date { get; set; }
        public string status { get; set; }
        public object test_clock { get; set; }
        public object transfer_data { get; set; }
        public object trial_end { get; set; }
        public TrialSettings trial_settings { get; set; }
        public object trial_start { get; set; }
    }

    public class TrialSettings
    {
        public EndBehavior end_behavior { get; set; }
    }

    public class AutomaticTax
    {
        public bool enabled { get; set; }
    }

    public class CancellationDetails
    {
        public object comment { get; set; }
        public object feedback { get; set; }
        public object reason { get; set; }
    }

    public class SubDatum
    {
        public string id { get; set; }
        public string @object { get; set; }
        public object billing_thresholds { get; set; }
        public int created { get; set; }
        public Metadata metadata { get; set; }
        public Plan plan { get; set; }
        public Price price { get; set; }
        public int quantity { get; set; }
        public string subscription { get; set; }
        public List<object> tax_rates { get; set; }
    }

    public class EndBehavior
    {
        public string missing_payment_method { get; set; }
    }

    public class Items
    {
        public string @object { get; set; }
        public List<SubDatum> data { get; set; }
        public bool has_more { get; set; }
        public int total_count { get; set; }
        public string url { get; set; }
    }

    public class PaymentSettings
    {
        public object payment_method_options { get; set; }
        public object payment_method_types { get; set; }
        public string save_default_payment_method { get; set; }
    }

    public class Plan
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

    public class Price
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
        public Recurring recurring { get; set; }
        public string tax_behavior { get; set; }
        public object tiers_mode { get; set; }
        public object transform_quantity { get; set; }
        public string type { get; set; }
        public int unit_amount { get; set; }
        public string unit_amount_decimal { get; set; }
    }

    public class Recurring
    {
        public object aggregate_usage { get; set; }
        public string interval { get; set; }
        public int interval_count { get; set; }
        public object trial_period_days { get; set; }
        public string usage_type { get; set; }
    }
}
