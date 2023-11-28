using System.Runtime.Serialization;

namespace DatingApp.Model.StripeModels.StripeResponse
{
    public class StripePaymentMethodResponse
    {
        public List<PaymentDatum> data { get; set; }
    }
    public class ThreeDSecureUsage
    {
        public bool supported { get; set; }
    }

    public class Address
    {
        public object city { get; set; }
        public object country { get; set; }
        public object line1 { get; set; }
        public object line2 { get; set; }
        public string postal_code { get; set; }
        public object state { get; set; }
    }

    public class BillingDetails
    {
        public Address address { get; set; }
        public object email { get; set; }
        public object name { get; set; }
        public object phone { get; set; }
    }
    [DataContract(Name = "card")]
    public class paymentCard
    {
        public string brand { get; set; }
        public Checks checks { get; set; }
        public string country { get; set; }
        public int exp_month { get; set; }
        public int exp_year { get; set; }
        public string fingerprint { get; set; }
        public string funding { get; set; }
        public object generated_from { get; set; }
        public string last4 { get; set; }
        public Networks networks { get; set; }
        public ThreeDSecureUsage three_d_secure_usage { get; set; }
        public object wallet { get; set; }
        public bool isDefault { get; set; } = false;
        public string CardLogo { get; set; }
    }

    public class Checks
    {
        public object address_line1_check { get; set; }
        public string address_postal_code_check { get; set; }
        public string cvc_check { get; set; }
    }

    [DataContract(Name = "data")]
    public class PaymentDatum
    {
        public string id { get; set; }
        public string @object { get; set; }
        public BillingDetails billing_details { get; set; }
        public paymentCard card { get; set; }
        public int created { get; set; }
        public string customer { get; set; }
        public bool livemode { get; set; }
        public Metadata metadata { get; set; }
        public string type { get; set; }
    }

    public class Networks
    {
        public List<string> available { get; set; }
        public object preferred { get; set; }
    }
}
