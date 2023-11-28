using System.Runtime.Serialization;

namespace DatingApp.Model.StripeModels.StripeResponse
{
    public class StripeSubscriptionUpdateResponse
    {
        public string id { get; set; }
        public string @object { get; set; }
        public object application { get; set; }
        public object canceled_at { get; set; }
        public object completed_at { get; set; }
        public int created { get; set; }
        public CurrentPhase current_phase { get; set; }
        public string customer { get; set; }
        public DefaultSettings default_settings { get; set; }
        public string end_behavior { get; set; }
        public bool livemode { get; set; }
        public Metadata metadata { get; set; }
        public List<Phase> phases { get; set; }
        public object released_at { get; set; }
        public object released_subscription { get; set; }
        public object renewal_interval { get; set; }
        public string status { get; set; }
        public string subscription { get; set; }
        public object test_clock { get; set; }
    }
    public class CurrentPhase
    {
        public int end_date { get; set; }
        public int start_date { get; set; }
    }

    public class DefaultSettings
    {
        public object application_fee_percent { get; set; }
        public AutomaticTax automatic_tax { get; set; }
        public string billing_cycle_anchor { get; set; }
        public object billing_thresholds { get; set; }
        public string collection_method { get; set; }
        public object default_payment_method { get; set; }
        public object default_source { get; set; }
        public object description { get; set; }
        public SubInvoiceSettings invoice_settings { get; set; }
        public object on_behalf_of { get; set; }
        public object transfer_data { get; set; }
    }

    [DataContract(Name = "InvoiceSettings")]
    public class SubInvoiceSettings
    {
        public object days_until_due { get; set; }
    }

    public class Item
    {
        public object billing_thresholds { get; set; }
        public Metadata metadata { get; set; }
        public string plan { get; set; }
        public string price { get; set; }
        public int quantity { get; set; }
        public List<object> tax_rates { get; set; }
    }
    public class Phase
    {
        public List<object> add_invoice_items { get; set; }
        public object application_fee_percent { get; set; }
        public AutomaticTax automatic_tax { get; set; }
        public object billing_cycle_anchor { get; set; }
        public object billing_thresholds { get; set; }
        public object collection_method { get; set; }
        public object coupon { get; set; }
        public string currency { get; set; }
        public object default_payment_method { get; set; }
        public List<object> default_tax_rates { get; set; }
        public object description { get; set; }
        public int end_date { get; set; }
        public object invoice_settings { get; set; }
        public List<Item> items { get; set; }
        public Metadata metadata { get; set; }
        public object on_behalf_of { get; set; }
        public string proration_behavior { get; set; }
        public int start_date { get; set; }
        public object transfer_data { get; set; }
        public object trial_end { get; set; }
    }
}