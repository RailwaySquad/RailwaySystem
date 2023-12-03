using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Railway_Group01.Data;
using Railway_Group01.Models;
using Railway_Group01.Models.ViewModels;
using System.Diagnostics;

namespace Railway_Group01.Controllers
{
    public class HomeController : Controller
    {
        RailwayDbContext _ctx;
        UserManager<User> _userManager;

        public HomeController(RailwayDbContext ctx, UserManager<User> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var stations = _ctx.Stations!.Select(s => new SelectListItem() { Text = s.Name, Value = s.Id.ToString() }).ToList();
            ViewData["Stations"] = stations;
            var model = new HomeViewModel();
            model.StationsSelectList = stations;

            return View(model);
        }


        public async Task<IActionResult> Search(int from, int to, DateTime date)
        {
            var d = date.ToString();
            var schedules = await _ctx.Schedules!.Where(s => s.Route!.StartStationId == from && s.Route.EndStationId == to && s.Departure.Date == date.Date).ToListAsync();
            return View(schedules);
        }







        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
