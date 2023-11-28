using DatingApp.Common.Helpers;
using DatingApp.Model.StripeModels.StripeRequest;
using DatingApp.Model.StripeModels.StripeResponse;
using DatingApp.Model.ViewModels.SubscriptionManagement;
using Microsoft.AspNetCore.Mvc;
using Stripe_demo.Service;

namespace Stripe_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscriptionController : Controller
    {
       
        private readonly IStripeService _stripeService;
        

        public SubscriptionController(IStripeService stripeService)
        {
            _stripeService = stripeService;
           
        }

        [HttpGet]
        [Route("GetSubscriptionPlanById/{planId}")]
        public async Task<IActionResult> GetPlanById(string planId)
        {
            ApiPostResponse<SubscriptionPlan> result = new();
            if (!string.IsNullOrEmpty(planId))
            {
                result = await _stripeService.GetSubscriptionPlanById(planId);
                return Ok(result);
            }
            else
            {
                result.Success = false;
                result.Message = Messages.InvalidPlan;
                return BadRequest(result);
            }
        }

       
        [HttpPost]
        [Route("SubscribeUser")]
      
        public async Task<IActionResult> SubscribeUser(SubscribePlanModel model)
        {
            var result = await _stripeService.SubscribeUser(model);
            return Ok(result);
        }

       

        [HttpGet]
        [Route("CreateSetupIntent")]
        public async Task<ActionResult> InitializePayment()
        {
            var response = await _stripeService.CreateSetupIntent();
            return Ok(response);
        }
    }
}
