namespace DatingApp.Model.StripeModels.StripeRequest
{
    public class StripeCardModel
    {
        public int CustomerId { get; set; }
        public string TokenId { get; set; }
        public string CardId { get; set; }
        public bool IsDefault { get; set; }
        public string Last4 { get; set; }
        public string Brand { get; set; }
    }
}
