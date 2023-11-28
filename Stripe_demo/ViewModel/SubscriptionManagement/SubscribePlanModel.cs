using System.ComponentModel.DataAnnotations;

namespace DatingApp.Model.ViewModels.SubscriptionManagement
{
    public class SubscribePlanModel
    {
        [Required(ErrorMessage = "Customer Id Required")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Plan Id Required")]
        public string PlanId { get; set; }
        public string paymentMethodId { get; set; }
    
    }
}
