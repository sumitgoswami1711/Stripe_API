using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Model.StripeModels.StripeResponse
{
    public class StripeDuplicateCardResponse
    {
        public string id { get; set; }
        public string @object { get; set; }
        public BillingDetails billing_details { get; set; }
        public Card card { get; set; }
        public int created { get; set; }
        public string customer { get; set; }
        public bool livemode { get; set; }
        public Metadata metadata { get; set; }
        public string type { get; set; }
    }
}
