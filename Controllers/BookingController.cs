using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Railway_Group01.Data;
using Railway_Group01.Models;
using Railway_Group01.Models.ViewModels;
using System.Collections.Generic;

namespace Railway_Group01.Controllers
{
    [Authorize(Roles = "Passenger")]
    public class BookingController : Controller
    {
        RailwayDbContext _ctx;
        UserManager<User> _userManager;


        public BookingController(RailwayDbContext ctx, UserManager<User> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
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

        public IActionResult FillInformation()
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> FillInformation(List<PassengerDTO> Passengers)
        {
            if (!ModelState.IsValid)
            {
                TempData["error"] = "Please fill the required field.";
                return RedirectToAction(nameof(Index));
            }
            var user = await _userManager.GetUserAsync(User);
            var cartsJSON = HttpContext.Session.GetString("listCart");
            if (cartsJSON == null)
            {
                TempData["error"] = "Cannot find Cart.";
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
                            PassengerType = passenger.PassengerType?.Name,
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
            var grandTotal = infoList.Sum(t => t.Price);

            var bookingNotBeingPay = _ctx.Bookings!.Where(b => b.User == user).SingleOrDefaultAsync(b => b.Transactions == null);
            if (bookingNotBeingPay != null)
            {
                await UpdateBookingTable(infoList);
                return View(nameof(ConfirmInformation), new ConfirmInformationViewModel()
                {
                    Passengers = Passengers,
                    Carts = carts,
                    User = user,
                    InfoList = infoList,
                    GrandTotal = grandTotal,
                    BookingId = bookingNotBeingPay.Id
                });
            }

            var booking = await CreateTables(infoList);

            return View(nameof(ConfirmInformation), new ConfirmInformationViewModel()
            {
                Passengers = Passengers,
                Carts = carts,
                User = user,
                InfoList = infoList,
                GrandTotal = grandTotal,
                BookingId = booking.Id
            });
        }

        private int GetDiscountPercent(string code)
        {
            return _ctx.PassengerTypes!.Find(code)!.Discount ?? 0;
        }

        private async Task<Booking> CreateTables(List<CartJoinPassenger> infoList)
        {
            var user = await _userManager.GetUserAsync(User);

            Booking booking = new()
            {
                User = user,
                CreatedAt = DateTime.Now
            };
            _ctx.Bookings!.Add(booking);
            await _ctx.SaveChangesAsync();

            foreach (var t in infoList)
            {

                BookingDetail bookingDetail = new()
                {
                    Booking = booking,
                    Seat = await _ctx.Seats!.FindAsync(t.SeatId),
                    Schedule = await _ctx.Schedules!.FindAsync(t.ScheduleId),
                    Price = t.Price
                };
                _ctx.BookingDetails!.Add(bookingDetail);

                Passenger passenger = new()
                {
                    ID = t.ID,
                    Birthday = t.Birthday,
                    Name = t.Name,
                    PassengerType = await _ctx.PassengerTypes!.SingleOrDefaultAsync(p => p.Name == t.PassengerType)
                };

                await _ctx.SaveChangesAsync();
            }
            return booking;
        }

        private async Task UpdateBookingTable(List<CartJoinPassenger> infoList)
        {
            foreach (var t in infoList)
            {
                var passenger = await _ctx.Passengers!.SingleOrDefaultAsync(p => p.ID == t.ID);
                if (passenger is not null)
                {
                    passenger.Name = t.Name;
                    passenger.PassengerType = await _ctx.PassengerTypes!.SingleOrDefaultAsync(p => p.Name == t.PassengerType);
                    passenger.Birthday = t.Birthday;
                    _ctx.Passengers!.Update(passenger);
                    await _ctx.SaveChangesAsync();
                }
            }
        }

        public IActionResult ConfirmInformation()
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult MakePayment(int id)
        {
            return View();
        }

        public IActionResult Pay()
        {
            return RedirectToAction(nameof(Finish));
        }

        public IActionResult Finish()
        {
            return View();
        }
    }
}
