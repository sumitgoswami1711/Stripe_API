using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Model.StripeModels.StripeResponse
{
    public class StripeTokenResponse
    {
        public string id { get; set; }
        public string @object { get; set; }
        public AchCreditTransfer ach_credit_transfer { get; set; }
        public object amount { get; set; }
        public string client_secret { get; set; }
        public int created { get; set; }
        public string currency { get; set; }
        public string flow { get; set; }
        public bool livemode { get; set; }
        public Metadata metadata { get; set; }
        public Owner owner { get; set; }
        public Receiver receiver { get; set; }
        public object redaction { get; set; }
        public object statement_descriptor { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string usage { get; set; }
    }

    public class AchCreditTransfer
    {
        public string account_number { get; set; }
        public string routing_number { get; set; }
        public string fingerprint { get; set; }
        public string bank_name { get; set; }
        public string swift_code { get; set; }
    }

    public class Owner
    {
        public object address { get; set; }
        public string email { get; set; }
        public object name { get; set; }
        public object phone { get; set; }
        public object verified_address { get; set; }
        public object verified_email { get; set; }
        public object verified_name { get; set; }
        public object verified_phone { get; set; }
    }

    public class Receiver
    {
        public string address { get; set; }
        public int amount_charged { get; set; }
        public int amount_received { get; set; }
        public int amount_returned { get; set; }
        public string refund_attributes_method { get; set; }
        public string refund_attributes_status { get; set; }
    }
}
