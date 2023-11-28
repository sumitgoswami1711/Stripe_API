namespace DatingApp.Model.StripeModels.StripeRequest
{
    public class StripePayment
    {
        public string CustomerId { get; set; }
        public string CustomerEmailAddress { get; set; }
        public string paymentIntentId { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public string PaymentMethod { get; set; }
        public string ReturnURL { get; set; }
    }
}