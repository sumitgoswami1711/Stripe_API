using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Model.StripeModels.StripeRequest
{
    public class StripeDefaultCardModel
    {
        [Required(ErrorMessage = "Customer Id Required")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "CardId  Required")]
        public string CardId { get; set; }
    }
}
