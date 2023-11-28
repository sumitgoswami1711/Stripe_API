namespace DatingApp.Model.StripeModels.StripeResponse
{
    public class StripeProductResponse
    {
        public string id { get; set; }
        public string @object { get; set; }
        public bool active { get; set; }
        public List<object> attributes { get; set; }
        public int created { get; set; }
        public object default_price { get; set; }
        public string description { get; set; }
        public List<object> feature_list { get; set; }
        public List<object> features { get; set; }
        public List<object> images { get; set; }
        public bool livemode { get; set; }
        public Metadata metadata { get; set; }
        public string name { get; set; }
        public string owning_merchant { get; set; }
        public string owning_merchant_info { get; set; }
        public object package_dimensions { get; set; }
        public object shippable { get; set; }
        public Skus skus { get; set; }
        public object statement_descriptor { get; set; }
        public object tax_code { get; set; }
        public string type { get; set; }
        public object unit_label { get; set; }
        public int updated { get; set; }
        public object url { get; set; }
        public bool user_hidden_in_lists { get; set; }
    }

    public class Skus
    {
        public string @object { get; set; }
        public List<object> data { get; set; }
        public bool has_more { get; set; }
        public int total_count { get; set; }
        public string url { get; set; }
    }
}
