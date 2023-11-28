namespace DatingApp.Common.Helpers
{
    public static class StripeApis
    {
        public static string baseAPI = "https://api.stripe.com/v1";

        //Plans (Product and Price) APIs
        public static string UpdateCustomer = baseAPI + "/customers/_customerId_";

        public static string AddProduct = baseAPI + "/products";
        public static string AddProductPrice = baseAPI + "/prices";
        public static string GetPlanById = baseAPI + "/prices/_planId_";
        public static string GetPlanList = baseAPI + "/plans";
        public static string ProductById = baseAPI + "/products/_productId_";
        public static string AddCustomerCard = baseAPI + "/payment_methods/_CardId_/attach";

        //One Time Payment APIs
        public static string CreatePaymentIntent = baseAPI + "/setup_intents";

        //Subscription APIs      
        public static string SubscribeUser = baseAPI + "/subscriptions";
    }
}
