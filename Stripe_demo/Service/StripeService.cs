using DatingApp.Common.Helpers;
using DatingApp.Model.StripeModels.StripeRequest;
using DatingApp.Model.StripeModels.StripeResponse;
using DatingApp.Model.ViewModels.SubscriptionManagement;
using DatingApp.Model.ViewModels.Token;
using Microsoft.Extensions.Options;
using Stripe;
using Stripe_demo.Helper;
using System.Net;
using System.Text.Json;

namespace Stripe_demo.Service
{
    public class StripeService : IStripeService
    {
        #region Declaration and Constructor
        private readonly StripeSetting _settings;
        public string customerId = "cus_P3hbB0emw8VdrZ";
        public StripeService(IOptions<StripeSetting> settings)
        {
            _settings = settings.Value;

        }
        #endregion

        public async Task<ApiPostResponse<Stripe.SetupIntent>> CreateSetupIntent()
        {

            var options = new SetupIntentCreateOptions
            {
                PaymentMethodTypes = new List<string> {
                    "card"
                }
            };

            var service = new SetupIntentService();
            var response = service.Create(options);
            return new ApiPostResponse<Stripe.SetupIntent> { Data = response, Success = true, Message = "Setup Intent Created" };
        }



        #region Create Stripe Plan
        /// <summary>
        /// For Creating Stripe Product & Pricing using Stripe API
        /// </summary>
        /// <param name="Plan Name"></param>
        /// <param name="Description"></param>
        /// <param name="Subscription Amount"></param>
        /// <param name="Currancy"></param>
        /// <param name="Interval"></param> like Month, 3 months, 6 months, 1 Years
        /// <param name="Interval Count"></param> interval / 12
        /// <param name="Free Trial"></param> if requred
        /// <returns></returns>

        public async Task<ApiPostResponse<SubscriptionPlan>> GetSubscriptionPlanById(string planId)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, StripeApis.GetPlanById.Replace("_planId_", planId));
            request.Headers.Add("Authorization", "Bearer " + _settings.secretKey);
            var response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = JsonSerializer.Deserialize<StripePlansResponse>(await response.Content.ReadAsStringAsync());
                var product = await GetProductInformationAsync(result.product);
                var plan = new SubscriptionPlan
                {
                    PlanName = product.name,
                    PlanDescription = product.description,
                    Charges = (Convert.ToDecimal(result.unit_amount) / 100).ToString("0.00"),
                    Interval = (result.recurring == null ? "" : result.recurring.interval),
                    IntervalCount = (result.recurring == null ? 0 : result.recurring.interval_count),
                    PriceId = result.id
                };
                return new ApiPostResponse<SubscriptionPlan> { Data = plan, Success = true, Message = Messages.StripePlanFound };
            }
            else
            {
                return new ApiPostResponse<SubscriptionPlan> { Data = null, Success = false, Message = Messages.FetchLisError };
            }
        }

        public async Task<StripeProductResponse> GetProductInformationAsync(string productId)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, StripeApis.ProductById.Replace("_productId_", productId));
            request.Headers.Add("Authorization", "Bearer " + _settings.secretKey);
            var collection = new List<KeyValuePair<string, string>>();
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var result = JsonSerializer.Deserialize<StripeProductResponse>(await response.Content.ReadAsStringAsync());
            return result;
        }
        #endregion

        #region Stripe Subscription
        /// <summary>
        /// Creating User Subscription Using Stripe API
        /// </summary>
        /// <param name="Stripe Customer Id"></param>
        /// <param name="Plan Id"></param>
        /// <param name="Token Id"></param>
        /// <returns></returns>
        public async Task<ApiPostResponse<StripeSubscriptionResponse>> SubscribeUser(SubscribePlanModel model)
        {

            //Here I am getting user details from m tables an create stripe customer

            //If  Stripe Customer Created successfully then we will create Customer and attach to customer
            var cardResponse = await AttachCardToCustomer(customerId, model.paymentMethodId);
            if (cardResponse.Success)
            {
                await SetDefaultCard(new StripeDefaultCardModel
                {
                    CardId = model.paymentMethodId,
                    CustomerId = 0
                });
            }
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, StripeApis.SubscribeUser);
            request.Headers.Add("Authorization", "Bearer " + _settings.secretKey);
            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new("customer", customerId)); // Customer id from stripe customer
            collection.Add(new("items[0][price]", model.PlanId));
            collection.Add(new("default_payment_method", model.paymentMethodId));
            collection.Add(new("metadata[IsExists]", ("false")));
            var content = new FormUrlEncodedContent(collection);
            request.Content = content;
            var response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = JsonSerializer.Deserialize<StripeSubscriptionResponse>(await response.Content.ReadAsStringAsync());
                return new ApiPostResponse<StripeSubscriptionResponse> { Data = result, Message = "Customer Subscription Created", Success = true };
            }
            else
            {
                return new ApiPostResponse<StripeSubscriptionResponse> { Data = null, Message = Messages.CreateSubscriptionError, Success = false };
            }
        }
        #endregion

        private async Task<BaseApiResponse> AttachCardToCustomer(string customerId, string paymentMethodId)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, StripeApis.AddCustomerCard.Replace("_CardId_", paymentMethodId));
            request.Headers.Add("Authorization", "Bearer " + _settings.secretKey);
            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new("customer", customerId));
            var content = new FormUrlEncodedContent(collection);
            request.Content = content;
            var response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var model = JsonSerializer.Deserialize<StripeCardResponse>(await response.Content.ReadAsStringAsync());
                return new BaseApiResponse { Message = Messages.CardAttachedSuccess, Success = true };
            }
            else
            {
                return new BaseApiResponse { Message = Messages.CardAttachedError, Success = false };
            }
        }

        public async Task<BaseApiResponse> SetDefaultCard(StripeDefaultCardModel model)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, StripeApis.UpdateCustomer.Replace("_customerId_", customerId));
            request.Headers.Add("Authorization", "Bearer " + _settings.secretKey);
            var collection = new List<KeyValuePair<string, string>>();
            collection.Add(new("invoice_settings[default_payment_method]", model.CardId));
            var content = new FormUrlEncodedContent(collection);
            request.Content = content;
            var response = await client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = JsonSerializer.Deserialize<StripeCustomerResponse>(await response.Content.ReadAsStringAsync());
                return new BaseApiResponse { Message = Messages.SetDefaultCardSuccess, Success = true };
            }
            else
            {
                return new BaseApiResponse { Message = Messages.SetDefaultCardError, Success = false };
            }
        }
    }
}
