using DatingApp.Common.Helpers;
using DatingApp.Model.StripeModels.StripeRequest;
using DatingApp.Model.StripeModels.StripeResponse;
using DatingApp.Model.ViewModels.SubscriptionManagement;

namespace Stripe_demo.Service
{
    public interface IStripeService
    {
        Task<ApiPostResponse<Stripe.SetupIntent>> CreateSetupIntent();
        Task<StripeProductResponse> GetProductInformationAsync(string productId);
        Task<ApiPostResponse<SubscriptionPlan>> GetSubscriptionPlanById(string planId);       
        Task<ApiPostResponse<StripeSubscriptionResponse>> SubscribeUser(SubscribePlanModel model);
        
    }
}
