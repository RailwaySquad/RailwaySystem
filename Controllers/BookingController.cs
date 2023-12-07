using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Railway_Group01.Data;
using Railway_Group01.Models;
using Railway_Group01.Models.ViewModels;

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
            }

            var selectPassengerType = await _ctx.PassengerTypes!.Select(t =>
                new SelectListItem() { Text = t.Name, Value = t.Code, Selected = t.Code == "AD" }
            ).ToListAsync();

            BookingIndexViewModel viewModel = new()
            {
                User = user,
                Cart = cart,
                PassengerTypes = selectPassengerType
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
        public IActionResult FillInformation(List<PassengerDTO> Passengers)
        {
            HttpContext.Session.SetString("Passengers", JsonConvert.SerializeObject(Passengers));
            return RedirectToAction(nameof(Confirm));
        }

        public IActionResult Confirm()
        {
            return View();
        }

        public IActionResult MakePayment()
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
