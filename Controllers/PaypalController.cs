using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json.Nodes;

namespace Railway_Group01.Controllers
{
    public class PaypalController: Controller
    {
        public string PaypalClientId { get; set; } = "";
        public string PaypalSecret { get; set; } = "";
        public string PaypalUrl { get; set; } = "";

        public PaypalController(IConfiguration configuration)
        {
            PaypalClientId = configuration["PaypalSettings:ClientId"]!;
            PaypalSecret = configuration["PaypalSettings:Secret"]!;
            PaypalUrl = configuration["PaypalSettings:Url"]!;
        }

        public ActionResult Index()
        {
            ViewData["PaypalClientId"] = PaypalClientId;
            ViewData["PaypalSecret"] = PaypalSecret;
            ViewData["PaypalUrl"] = PaypalUrl;
            return View();
        }

        [HttpPost]
        public ActionResult CreateOrder()
        {
            JsonObject createOrderRequest = new JsonObject();
            createOrderRequest.Add("intent", "CAPTURE");

            JsonObject amount = new JsonObject();
            amount.Add("currency_code", "USD");
            amount.Add("value", "100.00");

            JsonObject purchaseUnit1 = new JsonObject();
            purchaseUnit1.Add("amount", amount);

            JsonArray purchaseUnits = new JsonArray();
            purchaseUnits.Add(purchaseUnit1);

            createOrderRequest.Add("purchase_units", purchaseUnits);

            string accessToken = GetPaypalAccessToken();

            string url = PaypalUrl + "/v2/checkout/orders";

            string orderId = "";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
                requestMessage.Content = new StringContent(createOrderRequest.ToString(), null, "application/json");

                var responseTask = client.SendAsync(requestMessage);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var strResponse = readTask.Result;
                    var jsonResponse = JsonNode.Parse(strResponse);
                    if (jsonResponse != null)
                    {
                        orderId = jsonResponse["id"]!.ToString() ?? "";

                    }
                }
            }

            var response = new
            {
                Id = orderId
            };
            return new JsonResult(response);
        }

        [HttpPost]
        public ActionResult CompleteOrder(string orderID)
        {
            return new JsonResult(orderID);
        }

        private string GetPaypalAccessToken()
        {
            string accessToken = "";

            string url = PaypalUrl + "/v1/oauth2/token";

            using (var client = new HttpClient())
            {
                string credentials64 =
                    Convert.ToBase64String(Encoding.UTF8.GetBytes(PaypalClientId + ":" + PaypalSecret));

                client.DefaultRequestHeaders.Add("Authorization", "Basic " + credentials64);

                var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
                requestMessage.Content = new StringContent("grant_type=client_credentials", null
                    , "application/x-www-form-urlencoded");

                var responseTask = client.SendAsync(requestMessage);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    var strResponse = readTask.Result;

                    var jsonResponse = JsonNode.Parse(strResponse);
                    if (jsonResponse != null)
                    {
                        accessToken = jsonResponse["access_token"]?.ToString() ?? "";
                    }
                   
                }
            }

            return accessToken;
        }
    }
}
