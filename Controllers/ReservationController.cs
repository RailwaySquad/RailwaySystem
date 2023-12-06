using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Railway_Group01.Data;
using Railway_Group01.Models;

namespace Railway_Group01.Controllers
{
    [Authorize(Roles = "Passenger")]
    public class ReservationController: Controller
    {
        RailwayDbContext _ctx;

        public ReservationController(RailwayDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IActionResult> Booking()
        {
            string? listCart = HttpContext.Session.GetString("listCart");
            if (listCart != null)
            {
                List<CartDto>? carts = JsonConvert.DeserializeObject<List<CartDto>>(listCart);
                return View(carts);
            }
            return View();
        }
    }
}
