using System.ComponentModel.DataAnnotations;

namespace DatingApp.Model.StripeModels.StripeRequest
{
    public class StripeUpdateSubscription
    {
        [Required(ErrorMessage = "Please enter UserId")]
        public int UserId { get; set; }
        public string PlanId { get; set; }
        public string? PaymentMethodId { get; set; }
    }
}
