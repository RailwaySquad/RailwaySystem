using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using System.Text;
using System.Text.Json.Nodes;

namespace Railway_Group01.Controllers
{
    [Authorize(Roles = "Passenger")]
    public class PaypalController : Controller
    {
        RailwayDbContext _ctx;
        UserManager<User> _userManager;
        public string PaypalClientId { get; set; } = "";
        public string PaypalSecret { get; set; } = "";
        public string PaypalUrl { get; set; } = "";

        public PaypalController(IConfiguration configuration, RailwayDbContext ctx, UserManager<User> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
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
        public async Task<ActionResult> CreateOrder(int BookingId)
        {
            var user = await _userManager.GetUserAsync(User);
            var booking = await _ctx.Bookings!.Include(b => b.BookingDetails).FirstOrDefaultAsync(b => b.Id == BookingId);
            var amountValue = booking!.BookingDetails!.Sum(b => b.Price).ToString("0.00");

            JsonObject amount = new()
            {
                { "currency_code", "USD" },
                { "value", amountValue }
            };
            JsonObject purchaseUnit1 = new()
            {
                { "amount", amount }
            };
            JsonArray purchaseUnits = new()
            {
                purchaseUnit1
            };
            JsonObject createOrderRequest = new()
            {
                { "intent", "CAPTURE" },
                { "purchase_units", purchaseUnits }
            };

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

                        // save the order in the database
                        Transaction transaction = new()
                        {
                            PaymentId = orderId,
                            Receiver = "EaseTrain",
                            Amount = decimal.Parse(amountValue),
                            CreatedAt = DateTime.Now,
                            Booking = booking,
                            Sender = user.UserName
                        };
                        _ctx.Transactions!.Add(transaction);
                        await _ctx.SaveChangesAsync();
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
        public async Task<ActionResult> CompleteOrder([FromBody] JsonObject data)
        {
            if (data == null || data["orderID"] == null) return new JsonResult("");
            if (data["bookingID"] == null) return new JsonResult("");

            var orderID = data["orderID"]!.ToString();
            var bookingID = data["bookingID"]!.ToString();

            string accessToken = GetPaypalAccessToken();

            string url = PaypalUrl + $"/v2/checkout/orders/{orderID}/capture";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
                requestMessage.Content = new StringContent("", null, "application/json");

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
                        string paypalOrderStatus = jsonResponse["status"]?.ToString() ?? "";
                        if (paypalOrderStatus == "COMPLETED")
                        {
                            // update payment status in db
                            var transaction = await _ctx.Transactions!.SingleOrDefaultAsync(t => t.PaymentId == orderID);
                            if (transaction != null)
                            {
                                transaction.IsDone = true;
                                _ctx.Transactions!.Update(transaction);
                                await _ctx.SaveChangesAsync();
                            }
                            // Create ticket
                            var booking = await _ctx.Bookings!
                .Include(b => b.User)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Schedule)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Schedule).ThenInclude(s => s!.ListOfBookedSeatId)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Passenger)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Passenger).ThenInclude(p => p!.PassengerType)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Seat)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Seat).ThenInclude(s => s!.Coach)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Seat).ThenInclude(s => s!.Coach).ThenInclude(c => c!.Class)
                .FirstOrDefaultAsync(b => b.Id == int.Parse(bookingID));

                            foreach(var t in booking!.BookingDetails!)
                            {
                                Ticket ticket = new()
                                {
                                    PNRNo = "111" + new Random().Next(1000000, 9999999).ToString(),
                                    BookingDetail = t,
                                    Passenger = t.Passenger,
                                    Price = t.Price,
                                    Schedule = t.Schedule,
                                };
                                t.Schedule!.ListOfBookedSeatId!.Add(t.Seat!);
                                _ctx.Tickets!.Add(ticket);
                            }
                            await _ctx.SaveChangesAsync();
                            HttpContext.Session.Remove("listCart");
                            return new JsonResult("success");
                        }
                    }
                }
            }
            return new JsonResult("");
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
