using System.ComponentModel.DataAnnotations;

namespace DatingApp.Model.StripeModels.StripeRequest
{
    public class StripeDonationModel
    {
        [Required(ErrorMessage = " User Required")]
        public int UserId { get; set; }
        [Required(ErrorMessage = " Coach Required")]
        public int CoachId { get; set; }
        [Required(ErrorMessage = " Channel Id  Required")]
        public string ChannelId { get; set; }
        [Required(ErrorMessage = " Amount Required")]
        public decimal Amount { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Donation Date Required")]
        public DateTime DonationDate { get; set; }
    }
}
