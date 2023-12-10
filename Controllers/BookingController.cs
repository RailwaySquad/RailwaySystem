using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Railway_Group01.Data;
using Railway_Group01.Models;
using Railway_Group01.Models.ViewModels;
using System.Text.Json.Nodes;
using System.Text;

namespace Railway_Group01.Controllers
{
    [Authorize(Roles = "Passenger")]
    public class BookingController : Controller
    {
        RailwayDbContext _ctx;
        UserManager<User> _userManager;
        public string PaypalClientId { get; set; } = "";
        public string PaypalSecret { get; set; } = "";
        public string PaypalUrl { get; set; } = "";

        public BookingController(RailwayDbContext ctx, UserManager<User> userManager, IConfiguration configuration)
        {
            _ctx = ctx;
            _userManager = userManager;

            PaypalClientId = configuration["PaypalSettings:ClientId"]!;
            PaypalSecret = configuration["PaypalSettings:Secret"]!;
            PaypalUrl = configuration["PaypalSettings:Url"]!;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            string? cartJson = HttpContext.Session.GetString("listCart");

            if (cartJson == null)
                return View(new BookingIndexViewModel());

            var cart = JsonConvert.DeserializeObject<List<CartDto>>(cartJson);

            foreach (var item in cart!)
            {
                var schedule = await _ctx.Schedules!.FindAsync(item.ScheduleId);
                var route = await _ctx.Routes!.FindAsync(schedule!.RouteId);
                var train = await _ctx.Trains!.FindAsync(schedule!.TrainCode);
                var coach = await _ctx.Coaches!.FindAsync(item.CoachId);
                var fare = await _ctx.Fares!.FirstOrDefaultAsync(f =>
                    f.RouteId == schedule!.RouteId &&
                    f.ClassCode == coach!.ClassCode &&
                    f.TypeCode == train!.TypeCode
                );
                var start = await _ctx.RouteDetails!.Where(rd => rd.RouteId == route!.Id).SingleOrDefaultAsync(rd => rd.ArrivalStationId == item.FromStation);
                var end = await _ctx.RouteDetails!.Where(rd => rd.RouteId == route!.Id).SingleOrDefaultAsync(rd => rd.ArrivalStationId == item.ToStation);
                int distance = 0;
                if (start != null && end != null)
                    distance = end.Distance - start.Distance;
                item.Price = Railway_Group01.Service.Helper.CalculatePrice(distance, route!.Distance, fare!.Price);

                var seat = await _ctx.Seats!.Where(s => s.CoachId == item.CoachId).SingleOrDefaultAsync(s => s.SeatNo == item.Seat);
                item.SeatId = seat!.Id;
            }

            HttpContext.Session.SetString("listCart", JsonConvert.SerializeObject(cart));

            var passengerTypeSelectList = await _ctx.PassengerTypes!.Select(t =>
                new SelectListItem() { Text = t.Name, Value = t.Code, Selected = t.Code == "AD" }
            ).ToListAsync();

            BookingIndexViewModel viewModel = new()
            {
                User = user,
                Cart = cart,
                PassengerTypes = passengerTypeSelectList
            };
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            return View(viewModel);
        }

        public async Task<JsonResult> UpdateDiscountPrice(string code)
        {
            if (code == null) return Json(new { Success = "False", responseText = "code not null" });
            var discount = await _ctx.PassengerTypes!.FindAsync(code);
            return Json(new { Success = "True", response = discount!.Discount });
        }

        public async Task<JsonResult> UpdateUser(User updatedUser)
        {
            var user = await _userManager.GetUserAsync(User);
            user.Email = updatedUser.Email;
            user.PhoneNumber = updatedUser.PhoneNumber;
            _ctx.Users.Update(user);
            var result = await _ctx.SaveChangesAsync() > 0;
            return Json(new { Success = result, response = user });
        }

        [HttpPost]
        public async Task<IActionResult> FillInformation(List<PassengerDTO> Passengers)
        {
            var user = await _userManager.GetUserAsync(User);
            var bookingNotBeingPay = await _ctx.Bookings!.Where(b => b.User == user).AnyAsync(b => b.Transactions == null);
            if (bookingNotBeingPay)
            {
                TempData["error"] = "You have an unfinished order. Please check your Booking history";
                return RedirectToAction(nameof(Index));
            }

            var cartsJSON = HttpContext.Session.GetString("listCart");
            if (cartsJSON == null)
            {
                TempData["error"] = "Cannot find Cart.";
                return RedirectToAction(nameof(Index));
            }

            if (!ModelState.IsValid)
            {
                TempData["error"] = "Please fill the required field.";
                return RedirectToAction(nameof(Index));
            }

            var carts = JsonConvert.DeserializeObject<List<CartDto>>(cartsJSON);

            const string CHILD = "CH";
            const string STUDENT = "ST";
            const string ADULT = "AD";
            const string ELDERLY = "ED";

            foreach (var p in Passengers)
            {
                p.PassengerType = _ctx.PassengerTypes!.Find(p.TypeCode);
                switch (p.TypeCode)
                {
                    case CHILD:
                        {
                            p.Birthday = DateTime.Parse(p.ID!);
                            p.ID = Guid.NewGuid().ToString();
                            p.DiscountPercent = GetDiscountPercent(p.TypeCode);
                            break;
                        }
                    case STUDENT:
                    case ELDERLY:
                    case ADULT:
                        {
                            p.DiscountPercent = GetDiscountPercent(p.TypeCode);
                            break;
                        }
                    default: break;
                }

            }

            const decimal insurance = 0.1M;

            var query = from passenger in Passengers
                        join cart in carts! on passenger.SeatId equals cart.SeatId
                        select new CartJoinPassenger()
                        {
                            ID = passenger.ID,
                            Name = passenger.Name,
                            Birthday = passenger.Birthday,
                            PassengerType = passenger.PassengerType,
                            SeatId = passenger.SeatId,
                            ScheduleId = cart.ScheduleId,
                            ScheduleName = cart.ScheduleName,
                            Trip = cart.Trip,
                            StartAt = cart.StartAt,
                            CoachNo = cart.CoachNo,
                            Cabin = cart.Cabin,
                            SeatNo = cart.Seat,
                            CoachClassName = cart.CoachClassName,
                            Price = cart.Price - cart.Price * passenger.DiscountPercent / 100 - insurance
                        };
            var infoList = query.ToList();

            var booking = new Booking()
            {
                User = user,
                CreatedAt = DateTime.Now,
                BookingDetails = new List<BookingDetail>()
            };

            foreach (var info in infoList)
            {
                booking.BookingDetails!.Add(new BookingDetail()
                {
                    Booking = booking,
                    Schedule = await _ctx.Schedules!.FindAsync(info.ScheduleId),
                    Seat = await _ctx.Seats!.FindAsync(info.SeatId),
                    Trip = info.Trip,
                    Passenger = new Passenger()
                    {
                        ID = info.ID,
                        Birthday = info.Birthday,
                        Name = info.Name,
                        PassengerType = info.PassengerType,
                    },
                    Price = info.Price
            });
            }
            _ctx.Add(booking);
            var result = await _ctx.SaveChangesAsync() > 0;
            var bookModel = await _ctx.Bookings!.OrderBy(b => b.CreatedAt).LastOrDefaultAsync();
            return RedirectToAction(nameof(ConfirmInformation), new { id = bookModel?.Id });
        }

        private int GetDiscountPercent(string code)
        {
            return _ctx.PassengerTypes!.Find(code)!.Discount ?? 0;
        }

        public async Task<IActionResult> ConfirmInformation(int id)
        {
            var booking = await _ctx.Bookings!
                .Include(b => b.User)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Schedule)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Passenger)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Passenger).ThenInclude(p => p!.PassengerType)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Seat)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Seat).ThenInclude(s => s!.Coach)
                .Include(b => b.BookingDetails)!.ThenInclude(bd => bd.Seat).ThenInclude(s => s!.Coach).ThenInclude(c => c!.Class)
                .FirstOrDefaultAsync(b => b.Id == id);
            return View(booking);
        }

        public async Task<IActionResult> MakePayment(int id)
        {
            var booking = await _ctx.Bookings!.Include(b => b.BookingDetails).FirstOrDefaultAsync(b => b.Id == id);
            var amount = booking!.BookingDetails!.Sum(bd => bd.Price);
            var quantity = booking.BookingDetails!.Count;
            ViewBag.returnUrl = Request.Headers["Referer"].ToString();
            ViewData["PaypalClientId"] = PaypalClientId;
            ViewData["PaypalSecret"] = PaypalSecret;
            ViewData["PaypalUrl"] = PaypalUrl;
            OrderDTO order = new()
            {
                BookingId = id,
                Amount = amount,
                Quantity = quantity
            };
            return View(order);
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

        public IActionResult Finish()
        {
            return View();
        }
    }
}
