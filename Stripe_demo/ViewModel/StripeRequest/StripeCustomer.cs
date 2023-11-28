namespace DatingApp.Model.StripeModels.StripeRequest
{
    public class StripeCustomer
    {
        public int userId { get; set; }
        public string paymentMethodId { get; set; }
        public bool SetDefault { get; set; }
    }
}
